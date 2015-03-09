﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace StudyDemo.Framework.Knockout.Decompiler
{
    public class DecompiledQueryable : IOrderedQueryable
    {
        protected internal DecompiledQueryable(IQueryProvider provider, IQueryable inner)
        {
            this.inner = inner;
            this.provider = provider;
        }

        private readonly IQueryable inner;
        private readonly IQueryProvider provider;

        public Expression Expression
        {
            get { return inner.Expression; }
        }

        public Type ElementType
        {
            get { return inner.ElementType; }
        }

        public IQueryProvider Provider
        {
            get { return provider; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return inner.GetEnumerator();
        }

        public override string ToString()
        {
            return inner.ToString();
        }
    }

    public class DecompiledQueryable<T> : DecompiledQueryable, IOrderedQueryable<T>
    {
        private readonly IQueryable<T> inner;

        protected internal DecompiledQueryable(IQueryProvider provider, IQueryable<T> inner)
            : base(provider, inner)
        {
            this.inner = inner;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return inner.GetEnumerator();
        }
    }
}