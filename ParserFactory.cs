namespace Task1
{
    public class ParserFactory
    {
        XMLParser xmlParser = null;
        HttpParser httpParser = null;
        BinaryParser binaryParser = null;
        public AbstractParser GetParser(string parserType, string fileOrEndpoint)
        {
            switch (parserType)
            {
                case "bin":
                {
                    if (binaryParser)
                    {
                        return binaryParser;
                    }
                    else 
                    {
                        binaryParser = new BinaryParser(fileOrEndpoint);
                        return binaryParser;
                    }
                    break;
                }
                
                case "xml":
                {
                    if (xmlParser)
                    {
                        return xmlParser;
                    }
                    else 
                    {
                        xmlParser = new XMLParser(fileOrEndpoint);
                        return xmlParser;
                    }
                    break;
                }

                case "http":
                {
                    if (httpParser)
                    {
                        return httpParser;
                    }
                    else 
                    {
                        httpParser = new HttpParser(fileOrEndpoint);
                        return httpParser;
                    }
                    break;
                }
            }
        }
    }
}