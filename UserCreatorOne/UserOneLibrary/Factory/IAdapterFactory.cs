using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserOneLibrary.Adapter;
using UserOneLibrary.Enums;

namespace UserOneLibrary.Factory
{
    public interface IAdapterFactory<J> : IFactory<J>
        where J : IAdapter
    {
        public J Create(AdapterTypeEnum adapterType);
    }
}
