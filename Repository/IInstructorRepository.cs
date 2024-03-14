using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Model;

namespace E_Learning_Management_System.Repository
{
    public interface IInstructorRepository
    {
        Task<IEnumerable<InstructorDTO>> GetAll();
        Task<InstructorDTO> GetById(int id);
        Task GetByName(string name);
        Task Insert(InstructorDTO cart);
        Task Update(int id, InstructorDTO cart);
        Task DeleteById(int id);
    }
}
