using System.Globalization;
using System.Text;
using static JugendSpracheAPI.BL.Constants;
using JugendSpracheAPI.Interfaces;
using Microsoft.Extensions.FileProviders;

namespace JugendSpracheAPI.BL.File
{
    public class FileIO : IFileIO
    {
        public string FilePath = null;

        public string Write(string word, bool dateShouldBeAppended)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FilePath, dateShouldBeAppended, Encoding.GetEncoding(GermanEncoding)))
                {
                    sw.WriteLine($"{DateTime.Now.ToString(DateTimeFormat)};{word}");
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public SortedDictionary<DateTime, string> Read()
        {
            var allLines = new SortedDictionary<DateTime, string>();

            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Trim();

                        var data = line.Split(';');

                        allLines.Add(DateTime.ParseExact(data[0], DateTimeFormat, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None), data[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                allLines.Clear();
                allLines.Add(DateTime.MinValue, ex.Message);
            }

            return allLines;
        }
    }
}