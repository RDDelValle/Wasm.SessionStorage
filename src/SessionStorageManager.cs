using Microsoft.JSInterop;

namespace Wasm.SessionStorage;

internal class SessionStorageManager(IJSRuntime jsRuntime) : ISessionStorageManager, IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> _jsReference = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
        "import", "./_content/Wasm.SessionStorage/scripts.js").AsTask());


    public async ValueTask<string?> GetItemAsync(string key)
    {
        var js = await _jsReference.Value;
        return await js.InvokeAsync<string>("getItem", key);
    }

    public async ValueTask SetItemAsync(string key, string value)
    {
        var js = await _jsReference.Value;
        await js.InvokeVoidAsync("setItem", key, value);
    }

    public async ValueTask RemoveItemAsync(string key)
    {
        var js = await _jsReference.Value;
        await js.InvokeVoidAsync("removeItem", key);
    }

    public async ValueTask ClearAsync()
    {
        var js = await _jsReference.Value;
        await js.InvokeVoidAsync("clear");
    }

    public async ValueTask DisposeAsync()
    {
        if (_jsReference.IsValueCreated)
        {
            var module = await _jsReference.Value;
            await module.DisposeAsync();
        }
    }
}