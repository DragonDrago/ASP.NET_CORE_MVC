using StaffManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffManagement.DataAccess.Models
{
    public class SqlServerStaffRepository : IStaffRepository
    {
        private readonly AppDbContext dbContext;
        public SqlServerStaffRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Staff Create(Staff staff)
        {
           dbContext.Staffs.Add(staff);
           dbContext.SaveChanges();
           return staff;
        }

        public Staff Delete(int id)
        {
           var staff =  dbContext.Staffs.Find(id);
            if(staff != null)
            {
                dbContext.Staffs.Remove(staff);
                dbContext.SaveChanges();
            }
            return staff;
        }

        public Staff Get(int id)
        {
            return dbContext.Staffs.Find(id); 
        }

        public IEnumerable<Staff> GetAll()
        {
            return dbContext.Staffs;
        }

        public Staff Update(Staff updateStaff)
        {
          var staff =  dbContext.Staffs.Attach(updateStaff);
          staff.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
          dbContext.SaveChanges();
          return updateStaff;
        }
    }
}
