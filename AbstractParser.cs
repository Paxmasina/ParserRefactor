namespace BackendDeveloper.Assignment3
{
    public interface IParser
    {
        public abstract void StartParsing();
        public abstract IEnumerable<T> ProcessParsing<T>();
        public abstract void FinishParsing();
    }
}