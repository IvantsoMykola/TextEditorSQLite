using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace TextEditorSQLite.Helpers
{
    public static class Singleton
    {
        private static readonly ConcurrentDictionary<Type, object> instances = new ConcurrentDictionary<Type, object>();

        public static object Instance<T>() where T : new()
        {
            return instances.GetOrAdd(typeof(T), (t) => new T());
        }
    }
}
