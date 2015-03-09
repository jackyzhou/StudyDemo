using System.Web.Script.Serialization;
using Newtonsoft.Json;
using StudyDemo.Framework.Knockout.Decompiler;

namespace StudyDemo.KnockoutJs.Models
{
    public class ClickCounterModel
    {
        public int NumberOfClicks { get; set; }

        [Computed]
        [ScriptIgnore]
        [JsonIgnore]
        public bool HasClickedTooManyTimes
        {
            get { return NumberOfClicks >= 3; }
        }

        public void RegisterClick()
        {
            NumberOfClicks++;
        }

        public void ResetClicks()
        {
            NumberOfClicks = 0;
        }
    }
}