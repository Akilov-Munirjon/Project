namespace Project01.Application.Tokens
{
    public class TokenValidator
    {
        public static bool Validate(string token)
        {
            return !string.IsNullOrEmpty(token);
        }
    }
}
