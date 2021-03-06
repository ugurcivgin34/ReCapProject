using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        ////bizim algoritmammızı ve securte keyi belirlediğimiz nesnedir
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey) //asp .net core apinin de jwt yi tanımlaması için burayı kullanıyoruz
                                                                                           //jwt web abide oluşturulması için yapılır burda
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }

}

