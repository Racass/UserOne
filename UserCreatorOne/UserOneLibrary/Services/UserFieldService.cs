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
    public class UserFieldService : UserService<UserFieldModel>, IUserFieldService
    {
        public UserFieldService(IRepository<UserFieldModel> repository, IBOAdapter adapter) : base(repository, adapter)
        {
        }

        public void Add(UserFieldModel entity)
        {
            Repository.Add(entity);
        }

        public void Delete(UserFieldModel entity)
        {
            Repository.Delete(entity);
        }

        public void Update(UserFieldModel entity)
        {
            Repository.Update(entity);
        }
    }
}
