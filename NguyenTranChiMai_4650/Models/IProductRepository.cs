namespace NguyenTranChiMai_4650.Models
{
    //using System.Collections.Generic;
    //using YourNamespace.Models;
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void DeleteById(int id);
        void Delete(int id);
    }
}
