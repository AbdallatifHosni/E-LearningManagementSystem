using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Repository;

namespace E_LearningManagementSystem.Repository
{
    public class LearnerRepository : ILearnerRepository
    {
        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LearnerDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LearnerDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Insert(LearnerDTO cart)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, LearnerDTO cart)
        {
            throw new NotImplementedException();
        }
    }
}
