using System.Globalization;
using System.Text;
using static JugendSpracheAPI.BL.Constants;

namespace JugendSpracheAPI.BL.File
{
    public class FileIO
    {
        public void Write(string word, string fileName, bool dateShouldBeAppended)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, dateShouldBeAppended, Encoding.GetEncoding(GermanEncoding)))
                {
                    sw.WriteLine($"{DateTime.Now.ToString(DateTimeFormat)};{word}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static SortedDictionary<DateTime, string> Read(string path)
        {
            var allLines = new SortedDictionary<DateTime, string>();

            try
            {
                using (StreamReader sr = new StreamReader(Path.GetFullPath(path)))
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
            }

            return allLines;
        }
    }
}