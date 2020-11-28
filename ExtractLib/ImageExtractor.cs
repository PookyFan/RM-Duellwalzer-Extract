using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace ExtractLib
{
    public class ImageExtractor
    {
        private byte[] tmpBuf = new byte[4];
        private byte[] paletteData = new byte[256 * 4];

        public Bitmap ExtractImageFromFile(string filePath, int forcedWidth = -1, int forcedHeight = -1)
        {
            int width = forcedWidth;
            int height = forcedHeight;
            byte[] rawData = new byte[8];
            using(System.IO.FileStream file = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                file.Seek(0, SeekOrigin.End);
                long fileSize = file.Position;
                long extra = fileSize % 16;
                long extraAdd = 0;

                //Find footer start offset (relative to the EOF)
                do
                {
                    extra += extraAdd;
                    file.Seek(-64 - extra, SeekOrigin.End);
                    file.Read(rawData, 0, 8);
                    extraAdd = 1;
                } while(rawData[0] != 2 || rawData[1] != 0 || rawData[2] != 0 || rawData[3] != 0x70
                        || rawData[4] != 0 || rawData[5] != 0 || rawData[6] != 0 || rawData[7] != 0);

                //Get image dimension information from first header and footer
                file.Seek(0x44, SeekOrigin.Begin);
                file.Read(rawData, 0, 2);
                int pieceHeight = (rawData[1] << 8) | rawData[0];

                file.Seek(-4 - extra, SeekOrigin.End);
                file.Read(rawData, 0, 4);

                if(forcedWidth < 0)
                    width = (rawData[1] << 8) | rawData[0];
                if(forcedHeight < 0)
                    height = (rawData[3] << 8) | rawData[2];

                //Now we can read image data piece by piece
                rawData = new byte[width * height];
                file.Seek(0x70, SeekOrigin.Begin);
                for(int scanlinesRead = 0, totalReadData = 0; scanlinesRead < height;)
                {
                    if(scanlinesRead != 0)
                    {
                        //Get next piece's height and move to its data
                        file.Seek(68, SeekOrigin.Current);
                        file.Read(tmpBuf, 0, 2);
                        pieceHeight = (tmpBuf[1] << 8) | tmpBuf[0];
                        file.Seek(42, SeekOrigin.Current);
                    }

                    totalReadData += file.Read(rawData, totalReadData, pieceHeight * width);
                    scanlinesRead += pieceHeight;
                }

                //Read palette data (it's right after last image piece and some funky header)
                file.Seek(112, SeekOrigin.Current);
                file.Read(paletteData, 0, paletteData.Length);
            }

            //Make use of image and palette binary data
            Bitmap bmp = new Bitmap(width, height, width, System.Drawing.Imaging.PixelFormat.Format8bppIndexed,
                System.Runtime.InteropServices.Marshal.UnsafeAddrOfPinnedArrayElement(rawData, 0));
            
            ColorPalette palette = bmp.Palette;
            for(int i = 0; i < 256; ++i)
            {
                Color c = new Color();
                byte r = paletteData[4 * i], g = paletteData[4 * i + 1], b = paletteData[4 * i + 2]; //, a = paletteData[4 * i + 3];
                c = Color.FromArgb(r, g, b);
                palette.Entries[i] = c;
            }

            //Now just unswizzle and update image palette and we're done
            Color[] unswizzledColors;
            TilePalette(palette.Entries, out unswizzledColors);
            for(int i = 0; i < unswizzledColors.Length; ++i)
                palette.Entries[i] = unswizzledColors[i];

            bmp.Palette = palette;
            return bmp;

        }

        //Code from TGE from XeNTaX
        //https://github.com/TGEnigma/Amicitia/blob/35b1615c74ae3c3f9dd8dcf17f08ea0c0b7fdf3b/Source/AmicitiaLibrary/PS2/Graphics/PS2PixelFormatHelper.cs#L151
        public static void TilePalette(Color[] colorArray, out Color[] newColorArray)
        {
            newColorArray = new Color[colorArray.Length];
            int newIndex = 0;
            int oldIndex = 0;
            for(int i = 0; i < 8; i++)
            {
                for(int x = 0; x < 8; x++)
                {
                    newColorArray[newIndex++] = colorArray[oldIndex++];
                }
                oldIndex += 8;
                for(int x = 0; x < 8; x++)
                {
                    newColorArray[newIndex++] = colorArray[oldIndex++];
                }
                oldIndex -= 16;
                for(int x = 0; x < 8; x++)
                {
                    newColorArray[newIndex++] = colorArray[oldIndex++];
                }
                oldIndex += 8;
                for(int x = 0; x < 8; x++)
                {
                    newColorArray[newIndex++] = colorArray[oldIndex++];
                }
            }
        }
    }
}
