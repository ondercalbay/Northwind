using Northwind.Entities;
using System.Collections.Generic;

namespace Northwind.Dal.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
    }
}
