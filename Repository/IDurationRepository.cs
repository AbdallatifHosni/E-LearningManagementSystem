using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Model;

namespace E_Learning_Management_System.Repository
{
    public interface IDurationRepository
    {
        Task<IEnumerable<DurationDTO>> GetAll();
        Task<DurationDTO> GetById(int id);
        Task GetByName(string name);
        Task Insert(DurationDTO cart);
        Task Update(int id, DurationDTO cart);
        Task DeleteById(int id);
    }
}
