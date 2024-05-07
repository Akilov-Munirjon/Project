namespace Project01.Application.Tokens
{
    public class TokenService
    {
        public string HeaderName { get; } = "Authorization-Token";

        public string GenerateToken()
        {
            return Guid.NewGuid().ToString();
        }

    }
}
