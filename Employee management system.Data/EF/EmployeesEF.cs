using Employee_management_system.Core;
using Employee_management_system.Data.DBContext;

namespace Employee_management_system.Data.EF
{
    public class EmployeesEF : IDataHelper<Employees>
    {
        private EMSDBContext db;
        private Employees employees;
        public EmployeesEF()
        {
            db = new EMSDBContext();
            employees = new Employees();
        }

        public string Add(Employees table)
        {
            try
            {
                db.Employees.Add(table);
                db.SaveChanges();
                return "1";

            }
            catch (Exception ex) { return ex.Message; }
        }

        public string Delete(int id)
        {
            try
            {
                employees = Find(id);
                db.Employees.Remove(employees);
                db.SaveChanges();
                return "1";

            }
            catch (Exception ex) { return ex.Message; }
        }

        public string Edit(Employees table)
        {
            try
            {
                db = new EMSDBContext();
                db.Employees.Update(table);
                db.SaveChanges();
                return "1";

            }
            catch (Exception ex) { return ex.Message; }
        }

        public Employees Find(int id)
        {
            try
            {
                db = new EMSDBContext();
                return db.Employees.Find(id) ?? new Employees();

            }
            catch
            {
                return new Employees();
            }
        }


        public List<Employees> GetAlDatal()
        {
            try
            {
                db = new EMSDBContext();
                return db.Employees.OrderByDescending(x => x.Id).ToList();

            }
            catch
            {
                return new List<Employees>();
            }
        }

        public List<Employees> GetDataByUser(string userId)
        {
            try
            {
                db = new EMSDBContext();
                return db.Employees.Where(x => x.UsersId == userId).OrderByDescending(x => x.Id).ToList();

            }
            catch
            {
                return new List<Employees>();
            }
        }

        public bool ISCanConnect()
        {
            db = new EMSDBContext(); return db.Database.CanConnect();
        }



        public List<Employees> SearchAll(string searchIteam)
        {

            try
            {
                return db.Employees.Where(x => x.Id.ToString() == searchIteam ||
                x.UsersId == searchIteam ||

                x.Name.Contains(searchIteam) ||
                x.JopTitle.Contains(searchIteam) ||
                x.EmpState == searchIteam ||
                x.LastPromotionDate.ToString() == searchIteam ||


                x.CurrentDegree.ToString() == searchIteam ||
                x.CurrentStage.ToString() == searchIteam ||
                x.CurrentSalary.ToString() == searchIteam ||
                x.CurrentDate.ToString() == searchIteam ||

                x.NextDegree.ToString() == searchIteam ||
                x.NextStage.ToString() == searchIteam ||
                x.NextSalary.ToString() == searchIteam ||
                x.NextDate.ToString() == searchIteam ||

                x.Note.Contains(searchIteam) ||


                x.AddedDate.ToString() == searchIteam ||
                x.UpdateDate.ToString() == searchIteam

                )
                    .OrderByDescending(x => x.Id).ToList();

            }
            catch
            {
                return new List<Employees>();
            }
        }

        public List<Employees> SearchByUser(string userId, string searchIteam)
        {
            try
            {
                return db.Employees.Where(x => x.UsersId == userId).Where(x => x.Id.ToString() == searchIteam ||
                x.UsersId == searchIteam ||

                x.Name.Contains(searchIteam) ||
                x.JopTitle.Contains(searchIteam) ||
                x.EmpState == searchIteam ||
                x.LastPromotionDate.ToString() == searchIteam ||


                x.CurrentDegree.ToString() == searchIteam ||
                x.CurrentStage.ToString() == searchIteam ||
                x.CurrentSalary.ToString() == searchIteam ||
                x.CurrentDate.ToString() == searchIteam ||

                x.NextDegree.ToString() == searchIteam ||
                x.NextStage.ToString() == searchIteam ||
                x.NextSalary.ToString() == searchIteam ||
                x.NextDate.ToString() == searchIteam ||

                x.Note.Contains(searchIteam) ||


                x.AddedDate.ToString() == searchIteam ||
                x.UpdateDate.ToString() == searchIteam
                )
                    .OrderByDescending(x => x.Id).ToList();

            }
            catch
            {
                return new List<Employees>();
            }
        }
    }
}