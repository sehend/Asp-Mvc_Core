using Microsoft.AspNetCore.Identity;

namespace Core.Models
{
    public class UsersKulanıcı 
    {

        public int TC { get; set; }

        [PersonalData]
        public virtual bool TwoFactorEnabled { get; set; }
   
        [PersonalData]
        public virtual bool PhoneNumberConfirmed { get; set; }
       
        [ProtectedPersonalData]
        public virtual string PhoneNumber { get; set; }
       
        public virtual string ConcurrencyStamp { get; set; }
       
        public virtual string SecurityStamp { get; set; }
        
        public virtual string PasswordHash { get; set; }
      
        [PersonalData]
        public virtual bool EmailConfirmed { get; set; }
     
        public virtual string NormalizedEmail { get; set; }
       
        [ProtectedPersonalData]
        public virtual string Email { get; set; }
       
        public virtual string NormalizedUserName { get; set; }
     
        [ProtectedPersonalData]
        public virtual string UserName { get; set; }
      
        [PersonalData]
        public virtual int Id { get; set; }
     
        public virtual bool LockoutEnabled { get; set; }
      
        public virtual int AccessFailedCount { get; set; }

      
       

    }
}
