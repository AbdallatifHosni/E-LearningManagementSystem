using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Model;
using System.Collections;

namespace E_Learning_Management_System.Repository
{
    public interface IAdministratorRepository
    {
        Task<IEnumerable<AdministratorDTO>>GetAll();
        Task<AdministratorDTO> GetById(int id);
        Task GetByName(string name);
        Task Insert(AdministratorDTO cart);
        Task Update(int id, AdministratorDTO cart);
        Task DeleteById(int id);

    }
}
