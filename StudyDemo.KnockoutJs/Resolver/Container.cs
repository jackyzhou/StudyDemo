using Microsoft.Practices.Unity;
using StudyDemo.Manager;

namespace StudyDemo.KnockoutJs.Resolver
{
    public static class Container
    {
        public static UnityContainer InitUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IContactManager, ContactManager>(new HierarchicalLifetimeManager());
            //TODO:Other Service
            return container;
        }
    }
}