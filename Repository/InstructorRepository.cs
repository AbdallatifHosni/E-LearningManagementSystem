using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Repository;

namespace E_LearningManagementSystem.Repository
{
    public class InstructorRepository : IInstructorRepository
    {
        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InstructorDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<InstructorDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Insert(InstructorDTO cart)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, InstructorDTO cart)
        {
            throw new NotImplementedException();
        }
    }
}
