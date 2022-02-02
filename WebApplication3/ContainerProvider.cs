using Autofac;
using Microsoft.Extensions.Hosting;

namespace WebApplication3
{
    public static class ContainerProvider
    {
        public static IHost Container { get; set; }
    }
}
