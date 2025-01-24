
using Employee_management_system.Core;
using Employee_management_system.Data.DBContext;

namespace Employee_management_system.Data.EF
{
    public class UsersEF : IDataHelper<Users>
    {
        private EMSDBContext db;
        private Users users;
        public UsersEF()
        {
            db = new EMSDBContext();
            users = new Users();

        }

        public string Add(Users table)
        {
            try
            {
                db.Users.Add(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                users = Find(id);
                db.Users.Remove(users);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Edit(Users table)
        {

            try
            {
                db = new EMSDBContext();
                db.Users.Update(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Users Find(int id)
        {
            try
            {
                return db.Users.Find(id) ?? new Users();
            }
            catch
            {
                return new Users();

            }
        }

        public List<Users> GetAlDatal()
        {
            try
            {
                db = new EMSDBContext();
                return db.Users.OrderByDescending(x=>x.Id).ToList();
            }
            catch
            {
                return new List<Users>();
            }
        }

        public List<Users> GetDataByUser(string userid)
        {
            try
            {
                return db.Users.Where(x => x.UserId == userid).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<Users>();
            }
        }
        public bool ISCanConnect() 
        {
            db = new EMSDBContext(); return db.Database.CanConnect();
        }

        public List<Users> SearchAll(string searchItem)
        {
            try
            {
                return db.Users.Where(x => x.Id.ToString() == searchItem ||
                x.UserId == searchItem ||
                x.Address.Contains(searchItem) ||
                x.Email.Contains(searchItem) ||
                x.FullName.Contains(searchItem) ||
                x.Username.Contains(searchItem) ||
                x.Role.Contains(searchItem) ||
                x.CreatedDate.ToString().Contains(searchItem) ||
                x.EditedDate.ToString().Contains(searchItem)
                ).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<Users>();
            }
        }

        public List<Users> SearchByUser(string userid, string searchItem)
        {
            try
            {
                return db.Users.Where(x => x.UserId == userid).Where(x => x.Id.ToString() == searchItem ||
                x.UserId == searchItem ||
                x.Address.Contains(searchItem) ||
                x.Email.Contains(searchItem) ||
                x.FullName.Contains(searchItem) ||
                x.Username.Contains(searchItem) ||
                x.Role.Contains(searchItem) ||
                x.CreatedDate.ToString().Contains(searchItem) ||
                x.EditedDate.ToString().Contains(searchItem)
                ).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<Users>();
            }
        }
    }
}
