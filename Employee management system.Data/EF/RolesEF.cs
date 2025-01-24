
using Employee_management_system.Core;
using Employee_management_system.Data.DBContext;

namespace Employee_management_system.Data.EF
{
    public class RolesEF : IDataHelper<Roles>
    {
        private EMSDBContext db;
        private Roles roles;
        public RolesEF()
        {
            db = new EMSDBContext();
            roles = new Roles();

        }

        public string Add(Roles table)
        {
            try
            {
                db.Roles.Add(table);
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
                roles = Find(id);
                db.Roles.Remove(roles);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Edit(Roles table)
        {

            try
            {
                db = new EMSDBContext();
                db.Roles.Update(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Roles Find(int id)
        {
            try
            {
                return db.Roles.Find(id) ?? new Roles();
            }
            catch
            {
                return new Roles();

            }
        }

        public List<Roles> GetAlDatal()
        {
            try
            {
                db = new EMSDBContext();
                return db.Roles.OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<Roles>();
            }
        }

        public List<Roles> GetDataByUser(string userid)
        {
            try
            {
                db = new EMSDBContext();
                return db.Roles.Where(x => x.UsersId.ToString() == userid).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<Roles>();
            }
        }
        public bool ISCanConnect() 
        {
            db = new EMSDBContext(); return db.Database.CanConnect();
        }

        public List<Roles> SearchAll(string searchItem)
        {
            try
            {
                return db.Roles.Where(x => x.Id.ToString() == searchItem).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<Roles>();
            }
        }

        public List<Roles> SearchByUser(string userid, string searchItem)
        {
            try
            {
                return db.Roles.Where(x => x.UsersId.ToString() == userid).Where(x => x.Id.ToString() == searchItem ).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<Roles>();
            }
        }
    }
}
