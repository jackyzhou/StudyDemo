using System.Collections.Generic;

namespace StudyDemo.KnockoutJs.Models
{
    public class SimpleListModel
    {
        public string ItemToAdd { get; set; }
        public List<string> Items { get; set; }

        public void AddItem()
        {
            Items.Add(ItemToAdd);
            ItemToAdd = "";
        }
    }
}