namespace BackendDeveloper.Assignment3
{
    public class BinaryParser : IParser
    {
        private string fileToRead;
        private BinaryReader binaryReader;

        public BinaryParser(string file) 
        {
            fileToRead = file;
            binaryReader = ServiceLocator.Current.GetInstance<BinaryReader>();
        }
        public override void StartParsing()
        {
            binaryReader.Open(fileToRead);
        }
        public override IEnumerable<T> ProcessParsing<T>()
        {
            while (!binaryReader.HasReachedEnd)
            {
                yield return (T)parser.GetPerson();
            }
        }
        public override void FinishParsing() 
        {
            binaryReader.Close();
        }
    }
}