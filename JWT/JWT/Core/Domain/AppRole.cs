namespace JWT.Core.Domain
{
    public class AppRole
    {

        public int Id { get; set; }

        public string? Definition { get; set; }

        public List<AppUser> appUsers  { get; set; }

        public AppRole()
        {
            appUsers = new List<AppUser>();
        }

    }
}
