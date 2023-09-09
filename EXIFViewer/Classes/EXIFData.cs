using NExifTool;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXIFViewer.Classes
{
    public static class EXIFData
    {
        public static string FilePath { get; set; }
        public static string FileHASH { get; set; }

        public static List<KeyValuePair<string, string>> EXIF = new List<KeyValuePair<string, string>>();

        public static async Task GetEXIFData()
        {
            try
            {
                EXIF.Clear();

                var et = new ExifTool(new ExifToolOptions());
                var list = await et.GetTagsAsync(FilePath);

                foreach (var tag in list)
                {
                    EXIF.Add(new KeyValuePair<string, string>(tag.Description, " : " + tag.Value));
                }

                EXIFData.FileHASH = CalculateHASH.GetMD5HashFromFile(EXIFData.FilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        public static async void SaveEXIF()
        {
            try
            {
                if (EXIF != null)
                {
                    using (StreamWriter writer = File.CreateText(FilePath + ".txt"))
                    {
                        foreach (var data in EXIF)
                        {
                            await writer.WriteLineAsync(data.ToString());
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
