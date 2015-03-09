using System;

namespace StudyDemo.Framework.Knockout.Decompiler
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class ComputedAttribute : Attribute
    {
    }
}