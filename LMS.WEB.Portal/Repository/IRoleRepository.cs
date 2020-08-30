using LMSRestFullWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSRestFullWebAPI.Repository
{
    public interface IRoleRepository
    {
        void Add(Role role);
        IEnumerable<Role> GetRoles();
        Role GetRoleByID(int id);
        Role GetRoleByName(string roleName);
        void UpdateRole(Role role);
        void Save();
    }
}
