using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserOneLibrary.Enums;
using UserOneLibrary.Repository;
using UserOneLibrary.Services;

namespace UserOneLibrary.Factory
{
    public interface IRepositoryFactory<K> : IFactory<IRepository<K>>
        where K : IUserModel
    {
    }
}
