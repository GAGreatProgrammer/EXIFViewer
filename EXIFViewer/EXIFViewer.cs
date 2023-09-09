using Bunifu.UI.WinForms;
using EXIFViewer.Classes;
using EXIFViewer.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EXIFViewer
{
    public partial class EXIFViewer : Form
    {
        static EXIFViewer _object;

        public static EXIFViewer Instance
        {
            get
            {
                if (_object == null)
                {
                    _object = new EXIFViewer();
                }
                return _object;
            }
        }

        public EXIFViewer()
        {
            InitializeComponent();
        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.Icon;

            pbFile.AllowDrop = true;

            ScrollBar.Maximum = FilesPanel.VerticalScroll.Maximum;
            ScrollBar.ThumbLength = 100;

            btnInspect.Enabled = false;
            btnExport.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void btnInspect_Click(object sender, EventArgs e)
        {
            try
            {
                if (EXIFData.FilePath != null)
                {
                    dgvEXIF.DataSource = null;

                    btnInspect.Enabled = true;
                    btnExport.Enabled = false;

                    await EXIFData.GetEXIFData();

                    dgvEXIF.DataSource = EXIFData.EXIF;

                    dgvEXIF.Columns[0].HeaderText = "Tag name";
                    dgvEXIF.Columns[1].HeaderText = "Value";

                    dgvEXIF.CurrentCell = null;

                    FilesInfoUserControl FilesInfo = new FilesInfoUserControl();

                    FilesInfo.File.Text = EXIFData.FilePath;
                    FilesInfo.HASH.Text = EXIFData.FileHASH;

                    FilesPanel.Controls.Add(FilesInfo);

                    btnExport.Enabled = true;
                }

                else
                {
                    btnInspect.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScrollBar_Scroll(object sender, BunifuVScrollBar.ScrollEventArgs e)
        {
            FilesPanel.AutoScrollPosition = new Point(FilesPanel.AutoScrollPosition.X, e.Value);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (EXIFData.FilePath != null)
                {
                    btnExport.Enabled = true;

                    EXIFData.SaveEXIF();

                    MessageBox.Show("EXIF data file saved successfully!",
                        Application.ProductName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                else
                {
                    btnExport.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                ofdFile.InitialDirectory = @"C:\";
                ofdFile.Title = "EXIF Viewer";
                ofdFile.CheckFileExists = true;
                ofdFile.CheckPathExists = true;

                if (ofdFile.ShowDialog() == DialogResult.OK)
                {
                    btnInspect.Enabled = true;

                    EXIFData.FilePath = ofdFile.FileName;

                    lblFilePath.Text = ofdFile.FileName;

                    if (lblFilePath.Text.Length > 60)
                    {
                        lblFilePath.Text = lblFilePath.Text.Substring(0, 60) + "...";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelUploadFile_DragEnter_1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;

                pbFile.Image = Resources.UploadedFileEnter;
                panelUploadFile.IdleBorderColor = Color.FromArgb(78, 161, 250);
            }
        }

        private void panelUploadFile_DragLeave_1(object sender, EventArgs e)
        {
            pbFile.Image = Resources.UploadedFile;
            panelUploadFile.IdleBorderColor = Color.White;
        }

        private void panelUploadFile_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files != null && files.Length == 1)
                {
                    EXIFData.FilePath = files[0];
                    lblFilePath.Text = files[0];
                }

                if (lblFilePath.Text.Length > 60)
                {
                    lblFilePath.Text = lblFilePath.Text.Substring(0, 60) + "...";
                }

                pbFile.Image = Resources.UploadedFile;
                panelUploadFile.IdleBorderColor = Color.White;

                btnInspect.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;

                pbFile.Image = Resources.UploadedFileEnter;
                panelUploadFile.IdleBorderColor = Color.FromArgb(78, 161, 250);
            }
        }

        private void lblText_DragLeave(object sender, EventArgs e)
        {
            pbFile.Image = Resources.UploadedFile;
            panelUploadFile.IdleBorderColor = Color.White;
        }

        private void lblText_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files != null && files.Length == 1)
                {
                    EXIFData.FilePath = files[0];
                    lblFilePath.Text = files[0];
                }

                if (lblFilePath.Text.Length > 60)
                {
                    lblFilePath.Text = lblFilePath.Text.Substring(0, 60) + "...";
                }

                pbFile.Image = Resources.UploadedFile;
                panelUploadFile.IdleBorderColor = Color.White;

                btnInspect.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;

                pbFile.Image = Resources.UploadedFileEnter;
                panelUploadFile.IdleBorderColor = Color.FromArgb(78, 161, 250);
            }
        }

        private void lblFilePath_DragLeave(object sender, EventArgs e)
        {
            pbFile.Image = Resources.UploadedFile;
            panelUploadFile.IdleBorderColor = Color.White;
        }

        private void lblFilePath_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files != null && files.Length == 1)
                {
                    EXIFData.FilePath = files[0];
                    lblFilePath.Text = files[0];
                }

                if (lblFilePath.Text.Length > 60)
                {
                    lblFilePath.Text = lblFilePath.Text.Substring(0, 60) + "...";
                }

                pbFile.Image = Resources.UploadedFile;
                panelUploadFile.IdleBorderColor = Color.White;

                btnInspect.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;

                pbFile.Image = Resources.UploadedFileEnter;
                panelUploadFile.IdleBorderColor = Color.FromArgb(78, 161, 250);
            }
        }

        private void pbFile_DragLeave(object sender, EventArgs e)
        {
            pbFile.Image = Resources.UploadedFile;
            panelUploadFile.IdleBorderColor = Color.White;
        }

        private void pbFile_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files != null && files.Length == 1)
                {
                    EXIFData.FilePath = files[0];
                    lblFilePath.Text = files[0];
                }

                if (lblFilePath.Text.Length > 60)
                {
                    lblFilePath.Text = lblFilePath.Text.Substring(0, 60) + "...";
                }

                pbFile.Image = Resources.UploadedFile;
                panelUploadFile.IdleBorderColor = Color.White;

                btnInspect.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;

                pbFile.Image = Resources.UploadedFileEnter;
                panelUploadFile.IdleBorderColor = Color.FromArgb(78, 161, 250);
            }
        }

        private void btnChooseFile_DragLeave(object sender, EventArgs e)
        {
            pbFile.Image = Resources.UploadedFile;
            panelUploadFile.IdleBorderColor = Color.White;
        }

        private void btnChooseFile_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files != null && files.Length == 1)
                {
                    EXIFData.FilePath = files[0];
                    lblFilePath.Text = files[0];
                }

                if (lblFilePath.Text.Length > 60)
                {
                    lblFilePath.Text = lblFilePath.Text.Substring(0, 60) + "...";
                }

                pbFile.Image = Resources.UploadedFile;
                panelUploadFile.IdleBorderColor = Color.White;

                btnInspect.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
