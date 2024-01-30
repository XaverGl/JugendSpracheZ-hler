namespace JugendSpracheAPI.Interfaces
{
    public interface IFileIO
    {
        string Write(string word, bool dateShouldBeAppended);
        public SortedDictionary<DateTime, string> Read();
    }
}