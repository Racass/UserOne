using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserOneLibrary.Adapter;
using UserOneLibrary.Enums;
using UserOneLibrary.Exceptions;

namespace UserOneLibrary.Factory
{
    public class BOAdapterFactory : IAdapterFactory<IBOAdapter>
    {
        private static BOAdapter instance;
        public IBOAdapter CreateDefault()
        {
            instance ??= new BOAdapter();
            return instance;
        }

        public IBOAdapter Create(AdapterTypeEnum adapterType)
        {
            switch(adapterType)
            {
                case AdapterTypeEnum.None:
                    return CreateDefault();
                case AdapterTypeEnum.BO:
                    instance ??= new BOAdapter();
                    return instance;
                default:
                    throw new InvalidAdapterException("Invalid adapter type");
            }
        }

        public IBOAdapter Create()
        {
            throw new InvalidAdapterException("Invalid adapter type");
        }
    }
}
