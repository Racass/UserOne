using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserOneLibrary.Adapter;
using UserOneLibrary.Repository;
using UserOneLibrary.Services;

namespace UserOneLibrary.Factory
{
    public class ServiceFactory<T> : IServiceFactory<T>
        where T : IUserModel
    {
        private IRepositoryFactory<T> _repositoryFactory;
        private IAdapterFactory<IAdapter> _adapterFactory;

        public ServiceFactory(IRepositoryFactory<T> repositoryFactory, IAdapterFactory<IAdapter> adapterFactory)
        { 
            _repositoryFactory = repositoryFactory;
            _adapterFactory = adapterFactory;
        }

        public IService<T> Create()
        {
            if (typeof(T) == typeof(UserFieldModel))
                return new UserFieldService(_repositoryFactory.Create() as IRepository<UserFieldModel>, _adapterFactory.Create(Enums.AdapterTypeEnum.BO) as IBOAdapter) as IService<T>;
            else if (typeof(T) == typeof(UserTableModel))
                return new UserTableService(_repositoryFactory.Create() as IRepository<UserTableModel>, _adapterFactory.Create(Enums.AdapterTypeEnum.BO) as IBOAdapter) as IService<T>;
            else if (typeof(T) == typeof(UserObjectModel))
                return new UserObjectService(_repositoryFactory.Create() as IRepository<UserObjectModel>, _adapterFactory.Create(Enums.AdapterTypeEnum.BO) as IBOAdapter) as IService<T>;
            else
                throw new NotImplementedException();
        }

        public IService<T> CreateDefault()
        {
            throw new NotImplementedException();
        }
    }
}
