using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.DataAccess.Concrete.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            Database.SetInitializer(new MyIntializer());
        }

        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<ClassroomType> ClassroomTypes { get; set; }

        public DbSet<Corporation> Corporations { get; set; }
        public DbSet<CorporationAddress> CorporationAddresses { get; set; }
        public DbSet<CorporationEmployee> CorporationEmployees { get; set; }
        public DbSet<CorporationOwner> CorporationOwners { get; set; }

        public DbSet<CorporationSchoolManager> CorporationSchoolManagers { get; set; }
        public DbSet<CorporationStudent> CorporationStudents { get; set; }
        public DbSet<CorporationTeacher> CorporationTeachers { get; set; }
        public DbSet<Education> Educations { get; set; }

        public DbSet<EducationBranch> EducationBranches { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeJob> EmployeeJobs { get; set; }
        public DbSet<Job> Jobs { get; set; }

        public DbSet<SchoolManager> SchoolManagers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentReport> StudentReports { get; set; }
        public DbSet<SystemAdministrator> SystemAdministrators { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherField> TeacherFields { get; set; }
        public DbSet<UserRole> UserRole { get; set; }


    }
}
