using Microsoft.AspNetCore.Mvc.Filters;
using Project01.Core.Common.Configurations;
using Project01.Core.Common.Exceptions;
using System.Security.Cryptography;
using System.Text;

namespace Project01.Core.Common.Filters
{
    public class UserAutentificationFilter : ActionFilterAttribute
    {
        private readonly XorConfiguration _xor;

        public UserAutentificationFilter(XorConfiguration xor)
        {
            _xor = xor;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var canGet = context.HttpContext.Request.Headers.TryGetValue("X-Api-Key", out var token);

            if (!canGet)
                throw new UnauthorizedException("Не валидный токен");
            try
            {
                if (string.IsNullOrEmpty(token))
                    throw new UnauthorizedException("Не валидный токен");

                var tokenDecrypt = EncryptOrDecrypt(Decode(token.ToString()));

                var values = tokenDecrypt.Split(".");

                if (values.Length != 3)
                    throw new UnauthorizedException("Не валидный токен");

                var hash = Sha256($"{values[0]}.{values[1]}");

                if (!hash.Equals(values[2]))
                    throw new UnauthorizedException("Не валидный токен");
            }
            catch (Exception)
            {
                throw new UnauthorizedException("Не валидный токен");
            }
        }

        private string EncryptOrDecrypt(string payload)
        {
            var result = new StringBuilder();

            for (int c = 0; c < payload.Length; c++)
                result.Append((char)(payload[c] ^ (uint)_xor.SecretKey[c % _xor.SecretKey.Length]));

            return result.ToString();
        }

        private static string Sha256(string value)
        {
            var sb = new StringBuilder();
            using (var hash = SHA256.Create())
            {
                var enc = Encoding.UTF8;
                var result = hash.ComputeHash(enc.GetBytes(value));

                foreach (var b in result)
                    sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        private string Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
