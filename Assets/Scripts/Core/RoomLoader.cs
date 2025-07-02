using UnityEngine;
using UnityEngine.AddressableAssets;
using Cysharp.Threading.Tasks; // UniTask namespace

// Core: Handles loading of room prefabs via Addressables
public class RoomLoader
{
    public async UniTask<GameObject> LoadRoomAsync(string roomKey)
    {
        var handle = Addressables.LoadAssetAsync<GameObject>(roomKey);
        await handle.ToUniTask(); // Await as UniTask
        return handle.Result;
    }
} 