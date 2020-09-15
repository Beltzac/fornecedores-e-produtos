using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace Beltzac.FornecedoresProdutos.Dominio.Negocios.Seguranca
{
    public static class SenhaHelper
    {
        public static string GerarSal()
        {             
            byte[] salt = new byte[128 / 8]; //128 bits
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }

        public static string HashSenha(string senhaLimpa, string sal)
        {
            string hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: senhaLimpa,
                salt: Convert.FromBase64String(sal),
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000, //Precisa ser a mesma quantidade para o hash ser o mesmo
                numBytesRequested: 256 / 8)); //256 bits

            return hash;
        }

        public static bool IsSenhaValida(string senhaLimpa, string hashSenha, string sal)
        {
            string hash = HashSenha(senhaLimpa, sal);
            return hashSenha == hash;
        }    
    }
}
