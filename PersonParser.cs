namespace Task1
{
    public class PersonParser
    {
        public List<Person> Parse(string sourceType, string fileOrEndpoint)
        {
            ParserFactory parserFactory = new ParserFactory();
            AbstractParser parser = parserFactory.GetParser(sourceType, fileOrEndpoint);

            parser.StartParsing();
            parser.ProcessParsing();
            parser.FinishParsing();

            return parser.GetPersons();
        }
    }
}