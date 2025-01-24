
using Employee_management_system.Core;
using Employee_management_system.Data.DBContext;

namespace Employee_management_system.Data.EF
{
    public class SystemRecordsEF : IDataHelper<SystemRecords>
    {
        private EMSDBContext db;
        private SystemRecords systemRecords;
        public SystemRecordsEF()
        {
            db = new EMSDBContext();
            systemRecords = new SystemRecords();

        }

        public string Add(SystemRecords table)
        {
            try
            {
                db.SystemRecords.Add(table);
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
                systemRecords = Find(id);
                db.SystemRecords.Remove(systemRecords);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Edit(SystemRecords table)
        {

            try
            {
                db = new EMSDBContext();
                db.SystemRecords.Update(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public SystemRecords Find(int id)
        {
            try
            {
                return db.SystemRecords.Find(id) ?? new SystemRecords();
            }
            catch
            {
                return new SystemRecords();

            }
        }

        public List<SystemRecords> GetAlDatal()
        {
            try
            {
                db = new EMSDBContext();
                return db.SystemRecords.OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<SystemRecords>();
            }
        }

        public List<SystemRecords> GetDataByUser(string userid)
        {
            try
            {
                db = new EMSDBContext();
                return db.SystemRecords.Where(x => x.UsersId.ToString() == userid).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<SystemRecords>();
            }
        }
        public bool ISCanConnect()
        {
            db = new EMSDBContext(); return db.Database.CanConnect();
        }

        public List<SystemRecords> SearchAll(string searchItem)
        {
            try
            {
                return db.SystemRecords.Where(x => x.Id.ToString() == searchItem ||
                x.UsersId.ToString() == searchItem ||
                x.UserFullName.Contains(searchItem) ||
                x.MachinId == searchItem ||
                x.Title.Contains(searchItem) ||
                x.Description.Contains(searchItem) ||
                x.CreatedDate.ToString().Contains(searchItem)
                ).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<SystemRecords>();
            }
        }

        public List<SystemRecords> SearchByUser(string userid, string searchItem)
        {
            try
            {
                return db.SystemRecords.Where(x => x.UsersId.ToString() == userid).Where(x => x.Id.ToString() == searchItem ||
                x.UsersId.ToString() == searchItem ||
                x.UserFullName.Contains(searchItem) ||
                x.MachinId == searchItem ||
                x.Title.Contains(searchItem) ||
                x.Description.Contains(searchItem) ||
                x.CreatedDate.ToString().Contains(searchItem)
                ).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<SystemRecords>();
            }
        }
    }
}
