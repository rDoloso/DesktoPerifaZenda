using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PerifaZenda
{
    internal class Login
    {

        public (string hashSenha, string salt)HashSenha(string senha)
        {
            //Criar saltKey
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }

            string salt = Convert.ToBase64String(saltBytes);

            // Combinar o salt com a senha
            var senhaSalt = Encoding.UTF8.GetBytes(senha + salt);

            // Hashear a senha com SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(senhaSalt);
                string hashSenha = Convert.ToBase64String(hashBytes);

                return (hashSenha, salt);
            }
        }
        public static bool VerificarSenha(string senha, string saltKey, string hashSenha)
        {
            var senhaSalt = Encoding.UTF8.GetBytes(senha + saltKey);

            // Hashear a senha com SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(senhaSalt);
                string hashSenhaVerificar = Convert.ToBase64String(hashBytes);

                return hashSenhaVerificar == hashSenha; // Comparar hashes
            }
        }

    }
}
