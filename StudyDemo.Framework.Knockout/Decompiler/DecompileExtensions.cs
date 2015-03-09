using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace StudyDemo.Framework.Knockout.Decompiler
{
    public static class DecompileExtensions
    {
        private static readonly ConcurrentDictionary<MethodInfo, LambdaExpression> cache =
            new ConcurrentDictionary<MethodInfo, LambdaExpression>();

        public static LambdaExpression Decompile(this MethodInfo method)
        {
            LambdaExpression express = new MethodBodyDecompiler(method).Decompile();
            return cache.GetOrAdd(method, express);
        }
    }
}