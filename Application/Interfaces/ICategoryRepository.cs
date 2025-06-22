using System.Collections.Generic;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category? GetById(int id);
    }
}
