using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspPatterns.Chap2.Service
{
    public interface ICacheStorage
    {
        void Remove(string key);
        void Store(string key, object data);
        T Retreive<T>(string key);
    }
}
