using Microsoft.Extensions.DependencyInjection;
class Program
{
    static void Main(string[] args)
    {
		var serviceProvider = new ServiceCollection()
			// .AddTransient<IDependency, Dependency>() 
			// .AddSingleton<Func<IDependency>>(x => () => x.GetService<IDependency>()!) 
            .AddVehicleFactory()
            .AddTransient<Consumer>()
			.BuildServiceProvider();

        var consumer = serviceProvider.GetService<Consumer>();
        consumer?.PrintCurrentDateTime();
    }
}


