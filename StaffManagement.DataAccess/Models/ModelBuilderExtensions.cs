using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StaffManagement.Models;

namespace StaffManagement.DataAccess.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().HasData(
               new Staff
               {
                   Id = 1,
                   FirstName = "BirinchiXodim",
                   LastName = "Gafur",
                   Email = "hello@mail.ru",
                   Department = Departments.Admin,
                   PhotoFilePath =""
               },
                new Staff
                {
                    Id = 2,
                    FirstName = "IkkinchiXodim",
                    LastName = "Rauf",
                    Email = "go@mail.ru",
                    Department = Departments.HR,
                    PhotoFilePath = ""
                }
               );
        }
    }
}
