using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Model;

namespace E_Learning_Management_System.Repository
{
    public interface ICourseRepository
    {
        Task<IEnumerable<CourseDTO>> GetAll();
        Task<CourseDTO> GetById(int id);
        Task GetByName(string name);
        Task Insert(CourseDTO cart);
        Task Update(int id, CourseDTO cart);
        Task DeleteById(int id);
    }
}