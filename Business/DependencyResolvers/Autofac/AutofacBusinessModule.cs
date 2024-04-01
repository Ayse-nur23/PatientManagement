using Autofac;
using Business.Abstracts;
using Business.Concrete;

using DataAccess.Abstracts;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MedicineManager>().As<IMedicineService>().SingleInstance();
            builder.RegisterType<EfMedicineDal>().As<IMedicineDal>().SingleInstance();

            builder.RegisterType<DateManager>().As<IDateService>().SingleInstance();
            builder.RegisterType<EfDateDal>().As<IDateDal>().SingleInstance();

            builder.RegisterType<PatientManager>().As<IPatientService>().SingleInstance();
            builder.RegisterType<EfPatientDal>().As<IPatientDal>().SingleInstance();

            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
        }
    }
}
