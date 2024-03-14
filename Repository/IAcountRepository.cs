using E_Learning_Management_System.DTO;
using E_Learning_Management_System.Model;


namespace E_Learning_Management_System.Repository
{
    public interface IAcountRepository
    {
        public  List<Account> GetAll();
        public  Account GetById(string id);
        public Account GetByName(string name);
        public int Insert(Account cart);
        public int  Update(int id, Account cart);
        public int DeleteById(int id);



    }
}
