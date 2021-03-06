using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Collections.Generic;


namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper    //
    {
        public static SecurityKey CreateSecurityKey(string securityKey) //Burdaki security keyi  api  tarafondaki ayarlar da security kısmından alacak
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }

}

