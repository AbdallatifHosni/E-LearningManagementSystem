using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Repository;

namespace E_LearningManagementSystem.Repository
{
    public class CertificateRepository : ICertificateRepository
    {
        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CertificateDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CertificateDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Insert(CertificateDTO cart)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, CertificateDTO cart)
        {
            throw new NotImplementedException();
        }
    }
}
