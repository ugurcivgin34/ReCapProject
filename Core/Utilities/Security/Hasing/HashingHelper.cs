using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hasing
{
    public class HashingHelper  //Bizim için araçtır  ve meothodları static olduğu için Çıplak kalabilir
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)// out değer boş bile olsa doldurup olarak geri gelir
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));


            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)  //out a gerek yok , şifreleri biz giriceğiz
                                                                                                          //Kullanıcı sisteme tekrar girdiği zaman ikin ci kez şifre string password olan kısım.İlk girdiği değil yani.Doğrulama yapıyoruz burda
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
