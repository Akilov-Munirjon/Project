namespace Project01.Application.Tokens
{
    public static class TokenValidator
    {
        public static bool Validate(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return false;
            }

            return token == "valid_token_example";
        }
    }
}