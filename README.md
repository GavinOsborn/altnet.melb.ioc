# altnet.melb.ioc
A contrived example of IoC to demonstrate object lifetime/scope based on the exercise Jim proposed during the session.

This project was built using dotnet core 1.1 and Visual Studio 2017 RC

I leverage the out of the box IoC container new to ASP.NET rather than AutoFac.
AutoFac is great (and probably preferred) but just not neccesary for such a contribed example.

## Have a Play
The important bits of the project:
```csharp
// DefaultController.cs
[HttpGet]
public int Get()
{
    var a = _serviceA.GetValueA();
    var b = _serviceB.GetValueB();
    // TODO: Play with the different life cycles of the NumberGenerator
    // TODO: Can you tell what the returned value would be for
    //      Transient?
    //      Singleton?
    //      Scoped?
    // TODO: What about on the subsequent call to the API?
    return a + b;
}
```

```chsarp
// Startup.cs
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();

    //TODO: Play with these different container registrations to affect the behaviour of the system
    //services.AddTransient<INumberGenerator, NumberGenerator>();
    //services.AddSingleton<INumberGenerator, NumberGenerator>();
    services.AddScoped<INumberGenerator, NumberGenerator>();

    services.AddTransient<ServiceA>();
    services.AddTransient<ServiceB>();
}
```

Have a play with the 
Build and run the project and call the `/api/default` API to observe the number returned.
