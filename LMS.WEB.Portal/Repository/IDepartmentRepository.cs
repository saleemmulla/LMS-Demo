using LMSRestFullWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSRestFullWebAPI.Repository
{
    public interface IDepartmentRepository
    {
        void Add(Department department);
        IEnumerable<Department> GetDepartments();
        Department GetDepartmentByID(int id);
        Department GetDepartmentByName(string departmentName);
        void UpdateDepartment(Department department);
        void Save();
    }
}
