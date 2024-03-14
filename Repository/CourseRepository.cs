using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Repository;

namespace E_LearningManagementSystem.Repository
{
    public class CourseRepository : ICourseRepository
    {
        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CourseDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CourseDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Insert(CourseDTO cart)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, CourseDTO cart)
        {
            throw new NotImplementedException();
        }
    }
}
