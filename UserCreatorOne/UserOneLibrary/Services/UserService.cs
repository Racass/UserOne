using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserOneLibrary.Adapter;
using UserOneLibrary.Repository;

namespace UserOneLibrary.Services
{
    public abstract class UserService<T>
        where T : IUserModel
    {
        protected IRepository<T> Repository { get; private set; }
        protected IBOAdapter Adapter { get; private set; }

        public UserService(IRepository<T> repository, IBOAdapter adapter)
        {
            Repository = repository;
            Adapter = adapter;
        }
    }
}
