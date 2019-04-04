using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspPatterns.Chap2.Service
{
    public class NullCacheAdapter : ICacheStorage
    {
        public void Remove(string key)
        {
            //Do nothing
        }

        public T Retreive<T>(string key)
        {
            return default(T);
        }

        public void Store(string key, object data)
        {
            //Do nothing
        }
    }
}
