namespace BackendDeveloper.Assignment3
{
    public class BinaryParser : AbstractParser
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
        public override void ProcessParsing()
        {
            while (!binaryReader.HasReachedEnd)
            {
                persons.Add(parser.GetPerson());
            }
        }
        public override void FinishParsing() 
        {
            binaryReader.Close();
        }
    }
}