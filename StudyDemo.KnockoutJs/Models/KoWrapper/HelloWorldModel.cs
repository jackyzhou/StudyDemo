using System.Web.Script.Serialization;
using Newtonsoft.Json;
using StudyDemo.Framework.Knockout.Decompiler;

namespace StudyDemo.KnockoutJs.Models
{
    public class HelloWorldModel
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
}