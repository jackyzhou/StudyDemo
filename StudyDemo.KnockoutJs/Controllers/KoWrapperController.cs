using StudyDemo.KnockoutJs.Models;
using System.Collections.Generic;
using System.Threading;
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

        #region Click Counter

        public ActionResult ClickCounter()
        {
            //InitializeViewBag("Click counter");
            return View(new ClickCounterModel());
        }

        public ActionResult RegisterClick(ClickCounterModel model)
        {
            model.RegisterClick();
            return Json(model);
        }

        public ActionResult ResetClicks(ClickCounterModel model)
        {
            model.ResetClicks();
            return Json(model);
        }

        #endregion

        #region Simple List

        public ActionResult SimpleList()
        {
            //InitializeViewBag("Simple list");
            var model = new SimpleListModel { Items = new List<string> { "Alpha", "Beta", "Gamma" } };
            return View(model);
        }

        public ActionResult AddItem(SimpleListModel model)
        {
            model.AddItem();
            return Json(model);
        }

        #endregion 

        #region Better List
        public ActionResult BetterList()
        {
            //InitializeViewBag("Better list");
            var model = new BetterListModel
            {
                AllItems = new List<string> { "Fries", "Eggs Benedict", "Ham", "Cheese" },
                SelectedItems = new List<string> { "Ham" }
            };
            return View(model);
        }

        public ActionResult AddBetterItem(BetterListModel model)
        {
            model.AddItem();
            return Json(model);
        }

        public ActionResult RemoveSelected(BetterListModel model)
        {
            model.RemoveSelected();
            return Json(model);
        }

        public ActionResult SortItems(BetterListModel model)
        {
            model.SortItems();
            return Json(model);
        }
        #endregion 
    }
}
