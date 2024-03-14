using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Repository;

namespace E_LearningManagementSystem.Repository
{
    public class FeedbackRepository : IFeedbackRepository
    {
        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FeedbackDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<FeedbackDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Insert(FeedbackDTO cart)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, FeedbackDTO cart)
        {
            throw new NotImplementedException();
        }
    }
}
