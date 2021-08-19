namespace Task1
{
    public class PersonParser
    {
        public List<Person> Parse(string sourceType, string fileOrEndpoint)
        {
            ParserFactory parserFactory = new ParserFactory();
            AbstractParser parser = parserFactory.GetParser(sourceType, fileOrEndpoint);

            try{
                parser.StartParsing();
                return parser.ProcessParsing<Person>().ToList();            
            }
            catch(Exception e){
                // Log e
            }
            finally{
                parser.FinishParsing();
            }
            
        }
    }
}