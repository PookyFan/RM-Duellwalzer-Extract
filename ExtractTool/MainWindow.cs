using ExtractLib;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ExtractTool
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BrowseForGameFilesButton_Click(object sender, EventArgs e)
        {
            if(BrowserDialog.ShowDialog() == DialogResult.OK)
                GameFilesPathTextBox.Text = BrowserDialog.SelectedPath;
        }

        private void BrowseForOutputButton_Click(object sender, EventArgs e)
        {
            if(BrowserDialog.ShowDialog() == DialogResult.OK)
                OutputPathTextBox.Text = BrowserDialog.SelectedPath;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string gamePath = GameFilesPathTextBox.Text;
            string outPath = OutputPathTextBox.Text;
            if(gamePath.Length == 0 || outPath.Length == 0)
            {
                MessageBox.Show("You need to specify game files directory and output directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LogsTextBox.AppendText($"Starting extraction of game files localized in {gamePath}\r\n");
            if(ExtractImagesCheckBox.Checked)
            {
                ImageExtractor extractor = new ImageExtractor();
                string[] imageFiles = Directory.GetFiles(gamePath, "*.gsl", SearchOption.AllDirectories);
                LogsTextBox.AppendText($"Found {imageFiles.Length} image files\r\n");
                foreach(string filePath in imageFiles)
                {
                    LogsTextBox.AppendText($"Extracting image from {filePath}... ");
                    try
                    {
                        string[] pathParts = filePath.Split('\\');
                        string outDirectoryPath = $"{outPath}\\{pathParts[pathParts.Length - 2]}";
                        Directory.CreateDirectory(outDirectoryPath);

                        string outFileName = pathParts[pathParts.Length - 1].Split('.')[0];
                        string outFilePath = $"{outDirectoryPath}\\{outFileName}.png";

                        if(outFileName.Equals("title")) //The troublemaker
                            extractor.ExtractImageFromFile(filePath, 640, 448).Save(outFilePath, ImageFormat.Png);
                        else
                            extractor.ExtractImageFromFile(filePath).Save(outFilePath, ImageFormat.Png);
                        LogsTextBox.AppendText($"DONE! Saved in {outFilePath}\r\n");
                    }
                    catch(Exception err)
                    {
                        LogsTextBox.AppendText("FAILED!\r\n\r\n");
                    }
                }
            }

            LogsTextBox.AppendText("Extraction finished!\r\n\r\n");
        }
    }
}
