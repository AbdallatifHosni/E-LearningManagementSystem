using E_Learning_Management_System.Data;
using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Model;
using E_Learning_Management_System.Repository;

namespace E_LearningManagementSystem.Repository
{
    public class AcountRepository : IAcountRepository
    {
        private readonly ApplicatioDbContext _context;
        public AcountRepository(ApplicatioDbContext context) 
        {
            this._context = context;
        
        }
        public int DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAll()
        {
           var items = _context.Accounts.ToList();
        
            return items;
        
        }

        public Account GetById(string AccountAddress)
        {
            return _context.Accounts.FirstOrDefault(e=>e.AccountAddress== AccountAddress);
        }

        public Account GetByName(string name)
        {
            return _context.Accounts.FirstOrDefault(e => e.AccountAddress == name);

        }

        public int Insert(Account cart)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, Account cart)
        {
            throw new NotImplementedException();
        }
    }
}
