using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories
{
    public class CourseServices : ICourseServices
    {
        private readonly LMSDbContext dBContext;

        public CourseServices(LMSDbContext dBContext)
        {
            this.dBContext = dBContext;
        }


        public async Task<IEnumerable<CourseEntity>> GetAllCourseAsync()
        {
            return await dBContext.Courses.ToListAsync();

        }
    }
}
