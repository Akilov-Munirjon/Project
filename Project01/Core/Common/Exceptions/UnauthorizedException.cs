namespace Project01.Core.Common.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException() {}

        public UnauthorizedException(string? message) : base(message) {}
    }
}
