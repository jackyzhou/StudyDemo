using System.Collections.Generic;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using StudyDemo.Framework.Knockout.Decompiler;

namespace StudyDemo.KnockoutJs.Models
{
    public class InnerComputedItemModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Computed]
        [ScriptIgnore]
        [JsonIgnore]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }

    public class InnerComputedSubModel
    {
        public string Caption { get; set; }
        public int Value { get; set; }

        [Computed]
        [ScriptIgnore]
        [JsonIgnore]
        public string Message
        {
            get { return Caption + " = " + Value; }
        }
    }

    public class InnerComputedModel
    {
        public List<InnerComputedItemModel> Items { get; set; }
        public InnerComputedSubModel SubModel { get; set; }
    }
}