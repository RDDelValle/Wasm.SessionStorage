# Wasm.SessionStorage

1. Add Dependencies in Program.cs
* using Wasm.SessionStorage;
* builder.Services.AddWasmSessionStorage();


2. Inject Service
* @Inject ISessionStorageManager SessionStorage

3. Use one of the built in methods
* SessionStorage.SetItemAsync(Key, Value);
* SessionStorage.GetItemAsync(Key);
* SessionStorage.RemoveItemAsync(Key);
* SessionStorage.ClearAsync();
