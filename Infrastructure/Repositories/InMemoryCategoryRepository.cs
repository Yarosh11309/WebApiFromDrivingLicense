using System.Collections.Generic;
using System.Linq;
using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class InMemoryCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categories = new()
        {
            new Category { Id = 1, Name = "A" },
            new Category { Id = 2, Name = "B" },
            new Category { Id = 3, Name = "C" },
            new Category { Id = 4, Name = "D" }
        };

        public IEnumerable<Category> GetAll() => _categories;

        public Category? GetById(int id) => _categories.FirstOrDefault(c => c.Id == id);
    }
}
