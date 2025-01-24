using Employee_management_system.Data.DBContext;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_management_system.Data.EF
{
    public interface IDataHelper<Table>
    {
        //Read {Admin, User}
        List<Table> GetAlDatal(); //Admin
        List<Table> GetDataByUser(string userid); //User
        List<Table> SearchAll(string searchItem); //Admin
        List<Table> SearchByUser(string userid, string searchItem); //User
        Table Find (int id); 

        //Write
        string Add(Table table); // "1 == Success" , Error 
        string Edit(Table table); // "1 == Success" , Error
        string Delete(int id); // "1 == Success" , Error

        //Other

        bool ISCanConnect();
    }
}
