namespace Project01.Core.Comman.Exceptions
{
    public class NullDataException : Exception
    {
        public NullDataException() { }

        public NullDataException(string message) : base(message) { }

        public NullDataException(string message, Exception innerException) : base(message, innerException) { }
    }
}
