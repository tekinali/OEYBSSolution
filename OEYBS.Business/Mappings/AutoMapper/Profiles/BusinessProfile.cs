using AutoMapper;
using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.Mappings.AutoMapper.Profiles
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            CreateMap<AppRole, AppRole>();
            CreateMap<AppUser, AppUser>();
            CreateMap<Classroom, Classroom>();
            CreateMap<ClassroomType, ClassroomType>();

            CreateMap<Corporation, Corporation>();
            CreateMap<CorporationAddress, CorporationAddress>();
            CreateMap<CorporationEmployee, CorporationEmployee>();
            CreateMap<CorporationOwner, CorporationOwner>();

            CreateMap<CorporationSchoolManager, CorporationSchoolManager>();
            CreateMap<CorporationStudent, CorporationStudent>();
            CreateMap<CorporationTeacher, CorporationTeacher>();
            CreateMap<Education, Education>();

            CreateMap<EducationBranch, EducationBranch>();
            CreateMap<Employee, Employee>();
            CreateMap<SchoolManager, SchoolManager>();
            CreateMap<Student, Student>();

            CreateMap<StudentReport, StudentReport>();
            CreateMap<SystemAdministrator, SystemAdministrator>();
            CreateMap<Teacher, Teacher>();
            CreateMap<TeacherField, TeacherField>();

            CreateMap<UserRole, UserRole>();


        }
    }
}
