using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Repository;

namespace E_LearningManagementSystem.Repository
{
    public class ContentRepository : IContentRepository
    {
        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContentDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ContentDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Insert(ContentDTO cart)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, ContentDTO cart)
        {
            throw new NotImplementedException();
        }
    }
}
