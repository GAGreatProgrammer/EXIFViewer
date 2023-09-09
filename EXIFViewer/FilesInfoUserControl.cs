using Bunifu.UI.WinForms;
using System;
using System.Windows.Forms;

namespace EXIFViewer
{
    public partial class FilesInfoUserControl : UserControl
    {
        private string FileFullPath = null;

        public FilesInfoUserControl()
        {
            InitializeComponent();
        }

        private void FilesInfoUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                FileFullPath = lblFile.Text;

                if (lblFile.Text.Length > 50)
                {
                    lblFile.Text = lblFile.Text.Substring(0, 50) + "...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public BunifuLabel File
        {
            get { return lblFile; }
            set { lblFile = value; }
        }

        public BunifuLabel HASH
        {
            get { return lblHash; }
            set { lblHash = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
