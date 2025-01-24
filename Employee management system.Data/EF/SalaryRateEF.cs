
using Employee_management_system.Core;
using Employee_management_system.Data.DBContext;

namespace Employee_management_system.Data.EF
{
    public class SalaryRateEF : IDataHelper<SalaryRate>
    {
        private EMSDBContext db;
        private SalaryRate salaryRate;
        public SalaryRateEF()
        {
            db = new EMSDBContext();
            salaryRate = new SalaryRate();

        }

        public string Add(SalaryRate table)
        {
            try
            {
                db.SalaryRate.Add(table);
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
                salaryRate = Find(id);
                db.SalaryRate.Remove(salaryRate);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Edit(SalaryRate table)
        {

            try
            {
                db = new EMSDBContext();
                db.SalaryRate.Update(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public SalaryRate Find(int id)
        {
            try
            {
                return db.SalaryRate.Find(id) ?? new SalaryRate();
            }
            catch
            {
                return new SalaryRate();

            }
        }

        public List<SalaryRate> GetAlDatal()
        {
            try
            {
                db = new EMSDBContext();
                return db.SalaryRate.OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<SalaryRate>();
            }
        }

        public List<SalaryRate> GetDataByUser(string userid)
        {
            try
            {
                return db.SalaryRate.Where(x => x.UsersId == userid).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<SalaryRate>();
            }
        }
        public bool ISCanConnect()
        {
            db = new EMSDBContext(); return db.Database.CanConnect();
        }

        public List<SalaryRate> SearchAll(string searchItem)
        {
            try
            {
                return db.SalaryRate.Where(x => x.Id.ToString() == searchItem ||
                x.UsersId == searchItem ||
                x.Degree.ToString() == searchItem ||
                x.Salary.ToString() == searchItem ||
                x.BonusYearRate.ToString() == searchItem ||
                x.PromotionYear.ToString() == searchItem
                ).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<SalaryRate>();
            }
        }

        public List<SalaryRate> SearchByUser(string userid, string searchItem)
        {
            try
            {
                return db.SalaryRate.Where(x => x.UsersId == userid).Where(x => x.Id.ToString() == searchItem ||
                x.UsersId == searchItem ||
                x.Degree.ToString() == searchItem ||
                x.Salary.ToString() == searchItem ||
                x.BonusYearRate.ToString() == searchItem ||
                x.PromotionYear.ToString() == searchItem
                ).OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                return new List<SalaryRate>();
            }
        }
    }
}
