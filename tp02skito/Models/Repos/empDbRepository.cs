using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tp02skito.Data;

namespace tp02skito.Models.Repos
{
    public class empDbRepository : IOperationsModels<Employee>
    {
        AppDbContext db;
        public empDbRepository( AppDbContext _db)
        {
            db = _db;
        }
        public IList<Employee> FindAge(int id)
        {
            
            return db.employee.Where(x => x.empId == id).ToList(); 
        }

        public IList<Employee> FindBetween(int idone, int idtwo)
        {
            
            return db.employee.Where(x => x.empAge >= idone && x.empAge <= idtwo).ToList(); ;
        }
        public IList<Employee> FindByLetter(string letter)
        {
            
            return db.employee.Where(x => x.empName.StartsWith(letter)).ToList(); ;
        }

        public IList<Employee> List()
        {
            return db.employee.ToList();
        }
    }
}
