using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMSRestFullWebAPI.DBContexts;
using LMSRestFullWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LMSRestFullWebAPI.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DataBaseContext _dbContext;
        public RoleRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Role role)
        {
            var dptList = _dbContext.Roles.ToList();
            _dbContext.Roles.Add(role);
            Save();
        }
        public Role GetRoleByID(int id)
        {
            Role role = (from rl in _dbContext.Roles
                         where rl.ID == id
                         select rl
                        ).FirstOrDefault();
            return role;
        }

        public Role GetRoleByName(string roleName)
        {
            Role role = (from rl in _dbContext.Roles
                         where rl.RoleName== roleName
                         select rl
                        ).FirstOrDefault();
            return role;
        }

        public IEnumerable<Role> GetRoles()
        {
            try
            {
                return _dbContext.Roles.ToList();
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

        public void UpdateRole(Role role)
        {
            var local = _dbContext.Set<Department>()
                                   .Local
                                  .FirstOrDefault(entry => entry.ID.Equals(role.ID));
            if (local!=null)
            {
                _dbContext.Entry(local).State = EntityState.Detached;
            }
            _dbContext.Entry(role).State = EntityState.Modified;
            Save();
        }
    }
}
