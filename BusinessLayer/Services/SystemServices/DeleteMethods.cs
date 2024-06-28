using BusinessLayer.Services.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.SystemServices
{
    public static class DeleteMethods
    {
        public static async Task<bool> DeleteEntityAsync<T>(int id, IUnitOfWork unitOfWork) where T : class
        {
            var repository = unitOfWork.GetRepository<T>();
            var entity = await repository.GetByIdAsync(id);
            if (entity == null)
            {
                return false;
            }

            repository.Remove(entity);
            await unitOfWork.CompleteAsync();
            return true;
        }
    }
}
