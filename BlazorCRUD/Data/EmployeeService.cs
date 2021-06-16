using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class EmployeeService
    {
        public readonly ApplicationDbContext _db;

        public EmployeeService(ApplicationDbContext db)
        {
            _db = db;
        }

        //for CRUD operation

        //Get all employee
        public List<EmployeeInfo> GetEmployees()
        {
            var empList = _db.Employees.ToList();
            return empList;
        }

        //Insert employee info
        public string CreateEmployee(EmployeeInfo employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
            return "Save Successfully";
        }

        //Get employee by Id
        public EmployeeInfo GetEmployeeById(int id)
        {
            EmployeeInfo employee = _db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            return employee;
        }

        //Update employee info
        public string UpdateEmployee(EmployeeInfo employee)
        {
            _db.Employees.Update(employee);
            _db.SaveChanges();
            return "Update Successfully";
        }

        //Delete employee
        public string DeleteEmployee(EmployeeInfo employee)
        {
            _db.Remove(employee);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
