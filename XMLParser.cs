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
        public override void ProcessParsing()
        {
            Person parsedPerson;
            while ((parsedPerson = fileReader.GetNextPerson()) != null)
            {
                persons.Add(parsedPerson);
            }
        }

        public override void FinishParsing() 
        {
            xmlReader.Close();
        }
    }
}