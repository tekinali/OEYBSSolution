using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OEYBS.DataAccess.Abstract;
using OEYBS.DataAccess.Concrete.EntityFramework;
using OEYBS.Business.Abstract;
using OEYBS.Business.Concrete.Managers;
using System.Data.Entity;

namespace OEYBS.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            // Data Access
            Bind<IAppRoleDal>().To<EfAppRoleDal>().InSingletonScope();
            Bind<IAppUserDal>().To<EfAppUserDal>().InSingletonScope();
            Bind<IClassroomDal>().To<EfClassroomDal>().InSingletonScope();
            Bind<IClassroomTypeDal>().To<EfClassroomTypeDal>().InSingletonScope();

            Bind<ICorporationAddressDal>().To<EfCorporationAddressDal>().InSingletonScope();
            Bind<ICorporationDal>().To<EfCorporationDal>().InSingletonScope();
            Bind<ICorporationEmployeeDal>().To<EfCorporationEmployeeDal>().InSingletonScope();
            Bind<ICorporationOwnerDal>().To<EfCorporationOwnerDal>().InSingletonScope();

            Bind<ICorporationSchoolManagerDal>().To<EfCorporationSchoolManagerDal>().InSingletonScope();
            Bind<ICorporationStudentDal>().To<EfCorporationStudentDal>().InSingletonScope();
            Bind<ICorporationTeacherDal>().To<EfCorporationTeacherDal>().InSingletonScope();
            Bind<IEducationBranchDal>().To<EfEducationBranchDal>().InSingletonScope();

            Bind<IEducationDal>().To<EfEducationDal>().InSingletonScope();
            Bind<IEmployeeDal>().To<EfEmployeeDal>().InSingletonScope();
            Bind<IEmployeeJobDal>().To<EfEmployeeJobDal>().InSingletonScope();
            Bind<IJobDal>().To<EfJobDal>().InSingletonScope();

            Bind<ISchoolManagerDal>().To<EfSchoolManagerDal>().InSingletonScope();
            Bind<IStudentDal>().To<EfStudentDal>().InSingletonScope();
            Bind<IStudentReportDal>().To<EfStudentReportDal>().InSingletonScope();
            Bind<ISystemAdministratorDal>().To<EfSystemAdministratorDal>().InSingletonScope();


            Bind<ITeacherDal>().To<EfTeacherDal>().InSingletonScope();
            Bind<ITeacherFieldDal>().To<EfTeacherFieldDal>().InSingletonScope();
            Bind<IUserRoleDal>().To<EfUserRoleDal>().InSingletonScope();




            // Business
            Bind<IAppRoleService>().To<AppRoleManager>().InSingletonScope();
            Bind<IAppUserService>().To<AppUserManager>().InSingletonScope();
            Bind<IClassroomService>().To<ClassroomManager>().InSingletonScope();
            Bind<IClassroomTypeService>().To<ClassroomTypeManager>().InSingletonScope();

            Bind<ICorporationAddressService>().To<CorporationAddressManager>().InSingletonScope();
            Bind<ICorporationEmployeeService>().To<CorporationEmployeeManager>().InSingletonScope();
            Bind<ICorporationOwnerService>().To<CorporationOwnerManager>().InSingletonScope();
            Bind<ICorporationSchoolManagerService>().To<CorporationSchoolManagerManager>().InSingletonScope();

            Bind<ICorporationService>().To<CorporationManager>().InSingletonScope();
            Bind<ICorporationStudentService>().To<CorporationStudentManager>().InSingletonScope();
            Bind<ICorporationTeacherService>().To<CorporationTeacherManager>().InSingletonScope();
            Bind<IEducationBranchService>().To<EducationBranchManager>().InSingletonScope();

            Bind<IEducationService>().To<EducationManager>().InSingletonScope();
            Bind<IEmployeeJobService>().To<EmployeeJobManager>().InSingletonScope();
            Bind<IEmployeeService>().To<EmployeeManager>().InSingletonScope();
            Bind<IJobService>().To<JobManager>().InSingletonScope();

            Bind<ISchoolManagerService>().To<SchoolManagerManager>().InSingletonScope();
            Bind<IStudentReportService>().To<StudentReportManager>().InSingletonScope();
            Bind<IStudentService>().To<StudentManager>().InSingletonScope();
            Bind<ISystemAdministratorService>().To<SystemAdministratorManager>().InSingletonScope();

            Bind<ITeacherFieldService>().To<TeacherFieldManager>().InSingletonScope();
            Bind<ITeacherService>().To<TeacherManager>().InSingletonScope();
            Bind<IUserRoleService>().To<UserRoleManager>().InSingletonScope();
  


            Bind<DbContext>().To<DatabaseContext>();
        }
    }
}
