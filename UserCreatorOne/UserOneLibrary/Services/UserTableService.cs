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
    internal class UserTableService : UserService<UserTableModel>, IUserTableService
    {
        public UserTableService(IRepository<UserTableModel> repository, IBOAdapter adapter) : base(repository, adapter)
        {
        }

        public void Add(UserTableModel entity)
        {
            Repository.Add(entity);
        }

        public void Delete(UserTableModel entity)
        {
            Repository.Delete(entity);
        }

        public void Update(UserTableModel entity)
        {
            Repository.Update(entity);
        }
    }
}
