using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserOneLibrary.Services;

namespace UserOneLibrary.Factory
{
    public interface IServiceFactory<K> : IFactory<IService<K>>
        where K : IUserModel
    {
    }
}
