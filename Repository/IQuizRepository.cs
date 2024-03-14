using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Model;

namespace E_Learning_Management_System.Repository
{
    public interface IQuizRepository
    {
        Task<IEnumerable<QuizDTO>> GetAll();
        Task<QuizDTO> GetById(int id);
        Task GetByName(string name);
        Task Insert(QuizDTO cart);
        Task Update(int id, QuizDTO cart);
        Task DeleteById(int id);
    }
}
