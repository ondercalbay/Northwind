using Northwind.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;
using System.Data.Entity;

namespace Northwind.Dal.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        NorthwindContext _context = new NorthwindContext();
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}
