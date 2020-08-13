using DemonickGeneral.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemonickGeneral.Data.Repository
{
    public interface ICategoryRepository
    {
        Category AddCategory(Category newCategory);
    }
}
