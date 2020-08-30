using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMSRestFullWebAPI.DBContexts;
using LMSRestFullWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LMSRestFullWebAPI.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DataBaseContext _dbContext;
        public DepartmentRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Department department)
        {
            var dptList = _dbContext.Departments.ToList();
            _dbContext.Departments.Add(department);
            Save();
        }
        public Department GetDepartmentByID(int id)
        {
            Department department = (from dpt in _dbContext.Departments
                         where dpt.ID == id
                         select dpt
                        ).FirstOrDefault();
            return department;
        }

        public Department GetDepartmentByName(string departmentName)
        {
            Department department = (from dpt in _dbContext.Departments
                                     where dpt.DepartmentName==departmentName
                                     select dpt
                         ).FirstOrDefault();
            return department;
        }

        public IEnumerable<Department> GetDepartments()
        {
            try
            {
                return _dbContext.Departments.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateDepartment(Department department)
        {
            var local = _dbContext.Set<Department>()
                                   .Local
                                  .FirstOrDefault(entry => entry.ID.Equals(department.ID));
            if (local!=null)
            {
                _dbContext.Entry(local).State = EntityState.Detached;
            }
            _dbContext.Entry(department).State = EntityState.Modified;
            Save();
        }
    }
}
