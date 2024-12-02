using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.UserControls;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories
{
    public class UserServices : IUserServices
    {
        private readonly DbContextOptions<LMSDbContext> _dbContextOptions;

        public UserServices(DbContextOptions<LMSDbContext> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
        }

        public async Task<UserEntity?> GetUserByEmailAsync(string email)
        {
            using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
            {


                return await dbContextOptions.Users
                       .SingleOrDefaultAsync(u => u.Email == email);
            }
        }

        public async Task<IEnumerable<UserEntity>> GetAllUsersAsync()
        {
            using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
            {
                try
                {
                    return await dbContextOptions.Users
                          .Join(dbContextOptions.Courses,
                                 user => user.CourseId,
                                 course => course.CourseId,
                                 (user, course) => new UserEntity
                                 {
                                     UserId = user.UserId,
                                     FirstName = user.FirstName,
                                     LastName = user.LastName,
                                     CourseId = user.CourseId,
                                     CourseName = course.Course,
                                     UserPicture = user.UserPicture,
                                     CreatedAt = user.CreatedAt

                                 })


                        .ToListAsync();

                }
                catch (Exception ex)
                {
                    throw new Exception($"Error retrieving all Users. {ex.Message}", ex);
                }

            }
        }

        public async Task<IEnumerable<UserEntity>> GetUserByCourseAsync(int courseId)
        {
            using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
            {

                return await dbContextOptions.Users
                        .Where(u => u.CourseId == courseId)
                        .ToListAsync();
            }
        }

    }
}
