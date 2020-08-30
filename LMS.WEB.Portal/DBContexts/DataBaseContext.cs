using LMS.WEB.Portal.Models;
using LMS.WEB.Portal.OBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Portal.DBContexts
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DbSet<tbl_Users> tbl_Users { get; set; }
        public DbSet<tbl_Leaves> tbl_Leaves { get; set; }
        public DbSet<tbl_EmpDetails> tbl_EmpDetails { get; set; }
        public DbSet<tbl_Department> tbl_Departments { get; set; }
        public DbSet<tbl_Status> tbl_Status { get; set; }
        public DbSet<tbl_LeaveMaster> tbl_LeaveMasters { get; set; }
        public DbSet<tbl_LeaveType> tbl_LeaveTypes { get; set; }
    }
}
