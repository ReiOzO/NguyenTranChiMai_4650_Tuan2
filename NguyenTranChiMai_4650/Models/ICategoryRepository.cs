using System.Collections;

namespace NguyenTranChiMai_4650.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
