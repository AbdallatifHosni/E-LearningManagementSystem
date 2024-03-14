using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Model;

namespace E_Learning_Management_System.Repository
{
    public interface IFeedbackRepository
    {
        Task<IEnumerable<FeedbackDTO>> GetAll();
        Task<FeedbackDTO> GetById(int id);
        Task GetByName(string name);
        Task Insert(FeedbackDTO cart);
        Task Update(int id, FeedbackDTO cart);
        Task DeleteById(int id);
    }
}
