using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserOneLibrary.Enums;
using UserOneLibrary.Repository;

namespace UserOneLibrary.Factory
{
    public class RepositoryFactory<T> : IRepositoryFactory<T>
        where T : IUserModel
    {
        public IRepository<T> Create()
        {
            if (typeof(T) == typeof(IUserFieldRepository))
                throw new NotImplementedException();
            else if (typeof(T) == typeof(IUserTableRepository))
                throw new NotImplementedException();
            else if (typeof(T) == typeof(IUserObjectRepository))
                throw new NotImplementedException();
            else
                throw new NotImplementedException();
        }

        public IRepository<T> CreateDefault()
        {
            throw new NotImplementedException();
        }
    }
}
