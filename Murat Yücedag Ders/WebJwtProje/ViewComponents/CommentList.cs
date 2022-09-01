using Microsoft.AspNetCore.Mvc;
using WebJwtProje.Models;

namespace WebJwtProje.ViewComponents
{
    public class CommentList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            var commentValues=new List<UserComment>()
            {
                new UserComment()
                {
                    Id = 1,

                    UserName="fazıl"
                }, 

                new UserComment()

                {
                    Id = 2,

                    UserName="Mesut"
                },
                new UserComment()

                {
                    Id = 3,

                    UserName="Merve"
                },
            };



            return View(commentValues);
        }


    }
}
