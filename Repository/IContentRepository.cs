using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Model;

namespace E_Learning_Management_System.Repository
{
    public interface IContentRepository
    {
        Task<IEnumerable<ContentDTO>> GetAll();
        Task<ContentDTO> GetById(int id);
        Task GetByName(string name);
        Task Insert(ContentDTO cart);
        Task Update(int id, ContentDTO cart);
        Task DeleteById(int id);
    }
}
