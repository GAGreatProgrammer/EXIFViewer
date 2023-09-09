using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace EXIFViewer.Classes
{
    public static class CalculateHASH
    {
        public static string GetMD5HashFromFile(string fileName)
        {
            try
            {
                var md5 = MD5.Create();
                var stream = File.OpenRead(fileName);

                return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
