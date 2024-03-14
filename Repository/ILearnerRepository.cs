using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Model;

namespace E_Learning_Management_System.Repository
{
    public interface ILearnerRepository
    {
        Task<IEnumerable<LearnerDTO>> GetAll();
        Task<LearnerDTO> GetById(int id);
        Task GetByName(string name);
        Task Insert(LearnerDTO cart);
        Task Update(int id, LearnerDTO cart);
        Task DeleteById(int id);
    }
}
