namespace Wasm.SessionStorage;

public interface ISessionStorageManager
{
    ValueTask<string?> GetItemAsync(string key);
    ValueTask SetItemAsync(string key, string value);
    ValueTask RemoveItemAsync(string key);
    ValueTask ClearAsync();
}