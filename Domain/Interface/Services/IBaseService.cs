﻿using Domain.Models;

namespace Domain.Interface.Services
{
    public interface IBaseService<T> where T : BaseEntities
    {
        Task<IEnumerable<T>> GetRecords(string? keyword, int? page, int? pageSize);
        Task<T> GetRecord(int? id);
        Task<int?> Insert(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(List<int> id);
    }
}
