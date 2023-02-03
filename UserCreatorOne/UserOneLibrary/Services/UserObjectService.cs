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
    internal class UserObjectService : UserService<UserObjectModel>, IUserObjectService
    {
        public UserObjectService(IRepository<UserObjectModel> repository, IBOAdapter adapter) : base(repository, adapter)
        {
        }

        public void Add(UserObjectModel entity)
        {
            Repository.Add(entity);
        }

        public void Delete(UserObjectModel entity)
        {
            Repository.Delete(entity);
        }

        public void Update(UserObjectModel entity)
        {
            Repository.Update(entity);
        }
    }
}
