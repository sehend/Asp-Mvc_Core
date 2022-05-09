namespace JWT.Core.Application.Dto
{
    public class ChekUserResponsDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }=String.Empty;

        public string Role { get; set; }=String.Empty;

        public bool IsExist { get; set; }


    }
}
