namespace BackendDeveloper.Assignment3
{
    public class HttpParser : AbstractParser
    {
        private SomeApiClient apiClient;
        public HttpParser(string endpoint) 
        {
            apiClient = new SomeApiClient(endpoint);
        }
        public override void StartParsing()
        {
            apiClient.Connect();
        }
        public override void ProcessParsing()
        {
            Person parsedPerson;
            while ((parsedPerson = apiClient.GetNextPersonAsync().Result) != null)
            {
                persons.Add(parsedPerson);
            }
        }

        public override void FinishParsing() 
        {
            apiClient.Disconnect();
        }
    }
}