using Microsoft.Extensions.DependencyInjection;

namespace Wasm.SessionStorage;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWasmSessionStorage(this IServiceCollection services)
        => services.AddScoped<ISessionStorageManager, SessionStorageManager>();
}