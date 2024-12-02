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
        private readonly LMSDbContext applicationDbContext;

        public CourseServices(LMSDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }


        public async Task<IEnumerable<CourseEntity>> GetAllCourseAsync()
        {
            return await applicationDbContext.Courses.ToListAsync();

        }
    }
}
