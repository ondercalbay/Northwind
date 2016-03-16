using Northwind.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Northwind.Interfaces
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Product> GetAll();

        [OperationContract]
        Product Get(int productId);

        [OperationContract]
        void Add(Product product);

        [OperationContract]
        void Update(Product product);

        [OperationContract]
        void Delete(int productId);
    }
}
