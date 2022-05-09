using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class AppRole
    {
        [Key]
        public int Id { get; set; }

        public string Definition { get; set; }

        public List<Users> appUsers { get; set; }

        public AppRole()
        {
            appUsers = new List<Users>();
        }

    }
}
