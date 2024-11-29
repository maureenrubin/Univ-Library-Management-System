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
    public class CourseRepository : ICourseRepository
    {
        private readonly DbContextOptions<LMSDbContext> _applicationDbContext;

        public CourseRepository(DbContextOptions<LMSDbContext> dbContextOptions)
        {
            _applicationDbContext = dbContextOptions;
        }

       

        public async Task<IEnumerable<CourseEntity>> GetAllCourseAsync()
        {
            using (var dbContextOptionss = new LMSDbContext(_applicationDbContext))
            {
                return await dbContextOptionss.Courses.ToListAsync();
            }
        }
    }
}
