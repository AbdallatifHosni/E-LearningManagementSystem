using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Repository;

namespace E_LearningManagementSystem.Repository
{
    public class AdministratorRepository : IAdministratorRepository
    {
        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AdministratorDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AdministratorDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Insert(AdministratorDTO cart)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, AdministratorDTO cart)
        {
            throw new NotImplementedException();
        }
    }
}
