namespace BackendDeveloper.Assignment3
{
    public class XMLParser : AbstractParser
    {
        private XmlReader xmlReader;

        public XMLParser(File file) 
        {
            xmlReader = new XMLReader(file);
        }
        public override void StartParsing()
        {
            fileReader.Open(file);
        }
        public override IEnumerable<T> ProcessParsing<T>()
        {
            Person parsedPerson;
            while ((parsedPerson = fileReader.GetNextPerson()) != null)
            {
                yield return (T) parsedPerson;
            }
        }

        public override void FinishParsing() 
        {
            xmlReader.Close();
        }
    }
}