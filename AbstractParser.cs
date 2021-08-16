namespace BackendDeveloper.Assignment3
{
    abstract class AbstractParser
    {
        protected List<Person> persons;
        public AbstractParser()
        {
            persons = new PersonList();
        }
        public abstract void StartParsing();
        public abstract void ProcessParsing();
        public abstract void FinishParsing();
    }
}