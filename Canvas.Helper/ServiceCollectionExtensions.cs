using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Shapes.Helper
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register all types implementing an interface in a specified assembly
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="serviceDescriptors"></param>
        /// <param name="serviceLifetime"></param>
        public static void AddAllTypes<TType>(this IServiceCollection serviceDescriptors, ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            foreach (TypeInfo? type in typeof(TType).Assembly.DefinedTypes.Where(t => t.GetInterfaces().Contains(typeof(TType))))
            {
                if (type.IsAbstract)
                {
                    continue;
                }
                serviceDescriptors.Add(new ServiceDescriptor(type, type, serviceLifetime));
            }
        }
    }
}
