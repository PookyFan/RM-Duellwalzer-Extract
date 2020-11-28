using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIV
{
    public partial class AppWindow : Form
    {
        byte[] rawData = new byte[8];
        byte[] tmpBuf = new byte[4];
        byte[] paletteData;

        public AppWindow()
        {
            InitializeComponent();
        }

        private void AppWindow_DragDrop(object sender, DragEventArgs e)
        {
            string filePath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            FilePathTextBox.Text = filePath;
        }

        private void AppWindow_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        
        private void ViewButton_Click(object sender, EventArgs e)
        {
            int width = Decimal.ToInt32(WidthNumericControl.Value);
            int height = Decimal.ToInt32(HeightNumericControl.Value);
            ExtractLib.ImageExtractor extractor = new ExtractLib.ImageExtractor();
            Bitmap bmp = extractor.ExtractImageFromFile(FilePathTextBox.Text);
            ImageControl.Image = bmp;
        }
    }
}
