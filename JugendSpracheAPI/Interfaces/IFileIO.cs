namespace JugendSpracheAPI.Interfaces
{
    public interface IFileIO
    {
        string Write(string word, string fileName, bool dateShouldBeAppended);
        public SortedDictionary<DateTime, string> Read(string path);
    }
}
