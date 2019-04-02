using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspPatterns.Chap2.Service
{
    public class BasicCacheAdapter : ICacheStorage
    {
        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public T Retreive<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void Store(string key, object data)
        {
            throw new NotImplementedException();
        }
    }
}
