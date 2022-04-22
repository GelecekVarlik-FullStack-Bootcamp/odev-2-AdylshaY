using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface IGenericService<T, TDto> where T : IEntityBase where TDto : IDtoBase
    {
        // BLL katmanina verilecek
        // Genel olarak her modelde kullanilacak metotlar

        // Listeleme
        IResponse<List<TDto>> GetAll();
        // Filtreli Listeleme
        IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression);
        // Getirme 
        IResponse<TDto> Find(int id);
        // Kaydetme
        IResponse<TDto> Add(TDto item, bool saveChanges = true);
        // Async Kayetme
        Task<IResponse<TDto>> AddAsync(TDto item, bool saveChanges = true);
        // Guncelleme
        IResponse<TDto> Update(TDto item, bool saveChanges = true);
        // Async Guncelleme
        Task<IResponse<TDto>> UpdateAsync(TDto item, bool saveChanges = true);
        // Silme
        IResponse<bool> DeleteById(int id, bool saveChanges = true);
        // Async Silme
        Task<IResponse<bool>> DeleteByIdAsync(int id, bool saveChanges = true);
        // IQueryable listeleme
        IQueryable<TDto> GetQueryable();
    }
}
