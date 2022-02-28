using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotIdentity.CustomValidatation
{
    public class CustomIdentityErrorsDescriber : IdentityErrorDescriber
    {
        
        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError() { Code = "InvalidUserName", Description = $"Bu {userName} Geçersizdir" };
        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError() { Code = "DuplicateEmail", Description = $"Bu {email} Kulanılmaktadır" };
        }

        public override IdentityError PasswordTooShort(int length)
        {
             return new IdentityError() { Code = "PasswordTooShort", Description = $"Şifreniz En Az {length} Karakterli Olmalıdır" };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError() { Code = "DuplicateUserName", Description = $"Bu {userName} Zaten Kulanılmaktadır" };
        }

    }
}
