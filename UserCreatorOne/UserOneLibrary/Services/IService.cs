using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserOneLibrary.Services
{
    public interface IService<T>
        where T : IUserModel
    {
        /// <summary>
        /// Add the entity to system
        /// </summary>
        /// <param name="entity">Entity to add</param>
        public void Add(T entity);

        /// <summary>
        /// Update the entity to system
        /// </summary>
        /// <param name="entity">Entity to update</param>
        public void Update(T entity);

        /// <summary>
        /// Delete the entity from system
        /// </summary>
        /// <param name="entity">Entity to delete</param>
        public void Delete(T entity);
    }
}
