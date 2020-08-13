using DemonickGeneral.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemonickGeneral.Data.Repository
{
    public class MokCategoryRepository : ICategoryRepository
    {
        private List<Category> _listOfCategories;

        public MokCategoryRepository()
        {
            _listOfCategories = new List<Category>()
            {
                new Category() {Id = 1, Name = "C#"},
                new Category() {Id = 2, Name = "ASP .NET Core"},
                new Category() {Id = 3, Name = "Blazor"},
                new Category() {Id = 4, Name = "Razor Pages"},
                new Category() {Id = 5, Name = "Unity"}
            };
        }

        public Category AddCategory(Category newCategory)
        {
            int id = _listOfCategories.Max(x => x.Id) + 1;
            newCategory.Id = id;

            if (_listOfCategories.Any(x => x.Name == newCategory.Name))
            {
                newCategory.Name = null;
                return newCategory;
            }
            else
            {
                _listOfCategories.Add(newCategory);
                return newCategory;
            }
        }
    }
}
