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
            InitializeViewBag("Click counter");
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
            InitializeViewBag("Simple list");
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
            InitializeViewBag("Better list");
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

        #region Big Data

        public ActionResult BigData()
        {
            InitializeViewBag("Big data");
            return View();
        }

        public ActionResult InitialData(BigDataModel model)
        {
            model.LoadData();
            return Json(model);
        }

        #endregion

        #region Collections

        public ActionResult Collections()
        {
            InitializeViewBag("Collections");
            var model = new CollectionsModel();
            model.People = new List<CollectionsPersonModel>();
            model.People.Add(new CollectionsPersonModel
            {
                Name = "Annabelle",
                Children = new List<string> { "Arnie", "Anders", "Apple" }
            });
            model.People.Add(new CollectionsPersonModel
            {
                Name = "Bertie",
                Children = new List<string> { "Boutros-Boutros", "Brianna", "Barbie", "Bee-bop" }
            });
            model.People.Add(new CollectionsPersonModel
            {
                Name = "Charles",
                Children = new List<string> { "Cayenne", "Cleopatra" }
            });
            return View(model);
        }

        public ActionResult AddChild(CollectionsModel model, int index)
        {
            model.AddChild(index);
            return Json(model);
        }

        #endregion

        #region Combine Context

        public ActionResult CombineContext()
        {
            InitializeViewBag("Combine context");
            var model = new CombineContextModel
            {
                Key = "Global",
                Items = new List<CombineContextItemModel>
            {
              new CombineContextItemModel
                {
                  Caption = "Item 1",
                  SubItems = new List<CombineContextSubItemModel>
                    {
                      new CombineContextSubItemModel {Name = "SubItem1-1"},
                      new CombineContextSubItemModel {Name = "SubItem1-2"},
                      new CombineContextSubItemModel {Name = "SubItem1-3"},
                    }
                },
              new CombineContextItemModel
                {
                  Caption = "Item 2",
                  SubItems = new List<CombineContextSubItemModel>
                    {
                      new CombineContextSubItemModel {Name = "SubItem2-1"},
                      new CombineContextSubItemModel {Name = "SubItem2-2"},
                      new CombineContextSubItemModel {Name = "SubItem2-3"},
                    }
                }
            }
            };
            return View(model);
        }

        #endregion

        #region Complex Binding

        public ActionResult ComplexBinding()
        {
            InitializeViewBag("Complex binding");
            var model = new ComplexBindingModel
            {
                Price = -10,
                FontSize = "20px"
            };
            return View(model);
        }

        #endregion

        #region Contacts Editor

        public ActionResult ContactsEditor()
        {
            InitializeViewBag("Contacts editor");
            var model = new ContactsEditorModel();
            model.Contacts = new List<ContactsEditorContactModel>();
            model.Contacts.Add(new ContactsEditorContactModel
            {
                FirstName = "Danny",
                LastName = "LasRusso",
                Phones = new List<ContactsEditorPhoneModel>
          {
            new ContactsEditorPhoneModel {Type = "Mobile", Number = "(555) 121-2121"},
            new ContactsEditorPhoneModel {Type = "Home", Number = "(555) 123-4567"},
          }
            });
            model.Contacts.Add(new ContactsEditorContactModel
            {
                FirstName = "Sensei",
                LastName = "Miyagi",
                Phones = new List<ContactsEditorPhoneModel>
          {
            new ContactsEditorPhoneModel {Type = "Mobile", Number = "(555) 444-2222"},
            new ContactsEditorPhoneModel {Type = "Home", Number = "(555) 999-1212"},
          }
            });
            return View(model);
        }

        public ActionResult AddContact(ContactsEditorModel model)
        {
            model.AddContact();
            return Json(model);
        }

        public ActionResult DeleteContact(ContactsEditorModel model, int contactIndex)
        {
            model.DeleteContact(contactIndex);
            return Json(model);
        }

        public ActionResult AddPhone(ContactsEditorModel model, int contactIndex)
        {
            model.AddPhone(contactIndex);
            return Json(model);
        }

        public ActionResult DeletePhone(ContactsEditorModel model, int contactIndex, int phoneIndex)
        {
            model.DeletePhone(contactIndex, phoneIndex);
            return Json(model);
        }

        public ActionResult SaveJson(ContactsEditorModel model)
        {
            model.SaveJson();
            return Json(model);
        }

        #endregion

        #region Control Types

        public ActionResult ControlTypes()
        {
            InitializeViewBag("Control types");
            var model = new ControlTypesModel
            {
                StringValue = "Hello",
                PasswordValue = "mypass",
                BooleanValue = true,
                OptionValue = new List<string> { "Alpha", "Beta", "Gamma" },
                SelectedOptionValue = "Gamma",
                MultipleSelectedOptionValues = new List<string> { "Alpha" },
                RadioSelectedOptionValue = "Beta"
            };
            return View(model);
        }

        #endregion

        #region Gift List
        public ActionResult GiftList()
        {
            InitializeViewBag("Gift list");
            var model = new GiftListModel
            {
                Gifts = new List<GiftModel>
            {
              new GiftModel {Title = "Tall Hat", Price = 49.95},
              new GiftModel {Title = "Long Cloak", Price = 78.25}
            }
            };
            return View(model);
        }

        public ActionResult AddGift(GiftListModel model)
        {
            model.AddGift();
            return Json(model);
        }

        public ActionResult RemoveGift(GiftListModel model, int index)
        {
            model.RemoveGift(index);
            return Json(model);
        }

        public ActionResult Save(GiftListModel model)
        {
            model.Save();
            return Json(model);
        }
        #endregion

        #region Inner Computed

        public ActionResult InnerComputed()
        {
            InitializeViewBag("Inner computed properties");
            var model = new InnerComputedModel
            {
                Items = new List<InnerComputedItemModel>
            {
              new InnerComputedItemModel {FirstName = "Annabelle", LastName = "Arnie"},
              new InnerComputedItemModel {FirstName = "Bertie", LastName = "Brianna"},
              new InnerComputedItemModel {FirstName = "Charles", LastName = "Cayenne"},
            },
                SubModel = new InnerComputedSubModel
                {
                    Caption = "Count",
                    Value = 3
                }
            };
            return View(model);
        }

        #endregion
    }
}
