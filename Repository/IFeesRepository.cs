using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Model;

namespace E_Learning_Management_System.Repository
{
    public interface IFeesRepository
    {
        Task<IEnumerable<FeesDTO>> GetAll();
        Task<FeesDTO> GetById(int id);
        Task GetByName(string name);
        Task Insert(FeesDTO cart);
        Task Update(int id, FeesDTO cart);
        Task DeleteById(int id);
    }
}
