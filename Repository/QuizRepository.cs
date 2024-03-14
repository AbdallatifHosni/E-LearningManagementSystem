using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Repository;

namespace E_LearningManagementSystem.Repository
{
    public class QuizRepository : IQuizRepository
    {
        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<QuizDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<QuizDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Insert(QuizDTO cart)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, QuizDTO cart)
        {
            throw new NotImplementedException();
        }
    }
}
