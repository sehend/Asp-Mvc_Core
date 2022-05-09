namespace JWT.Core.Domain
{
    public class AppUser
    {
        public int Id { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public int AppRoleId { get; set; }

        public AppRole AppRoles { get; set; }

        // ctor da approle null olamıcagı için yazdık

        public AppUser()
        {
            AppRoles = new AppRole();
        }

    }
}
