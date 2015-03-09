using System;

namespace StudyDemo.Framework.Knockout.Decompiler
{
    class VariableInfo
    {
        public VariableInfo(Type type)
        {
            Type = type;
            Address = new Address();
        }

        public Type Type { get; set; }

        public Address Address { get; set; }
    }
}