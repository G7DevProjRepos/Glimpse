﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glimpse.Core2.Extensions
{
    public static class DictionaryExtensions
    {
        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> input, TKey key, TValue ifNotFound = default(TValue))
        {
            TValue val;
            return input.TryGetValue(key, out val) ? val : ifNotFound;
        }
    }
}
