using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserOneLibrary.Enums;

namespace UserOneLibrary.Factory
{
    public interface IFactory<T>
    {
        public T CreateDefault();
        public T Create();
    }
}
