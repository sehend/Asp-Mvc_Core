using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
	public class Users
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int AppRoleId { get; set; }

        public AppRole AppRoles { get; set; }

        // ctor da approle null olamıcagı için yazdık

        public Users()
        {
            AppRoles = new AppRole();
        }
    }
}
