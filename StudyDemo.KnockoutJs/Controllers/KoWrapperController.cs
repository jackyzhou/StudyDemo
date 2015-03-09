using StudyDemo.KnockoutJs.Models;
using System.Web.Mvc;

namespace StudyDemo.KnockoutJs.Controllers
{
    public class KoWrapperController : BaseController
    {
        #region Hello World

        public ActionResult HelloWorld()
        {
            InitializeViewBag("Hello world");
            return View(new HelloWorldModel
            {
                FirstName = "Steve",
                LastName = "Sanderson"
            });
        }

        #endregion 
    }
}
