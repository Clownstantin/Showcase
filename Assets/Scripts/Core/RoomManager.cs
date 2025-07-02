using Cysharp.Threading.Tasks; // UniTask namespace
using Zenject;

// Core: Manages room generation, loading, and instantiation
public class RoomManager
{
	private readonly ProceduralGenerator _generator;
	private readonly RoomLoader _loader;
	private readonly DiContainer _container;

	public RoomManager(ProceduralGenerator generator, RoomLoader loader, DiContainer container)
	{
		_generator = generator;
		_loader = loader;
		_container = container;
	}

	public async UniTask GenerateAndSpawnRooms(int count)
	{
		var rooms = _generator.GenerateRooms(count);
		foreach(var room in rooms)
		{
			// Replace "RoomPrefabKey" with your Addressable key for the room prefab
			var prefab = await _loader.LoadRoomAsync("RoomPrefabKey");
			var roomGO = _container.InstantiatePrefab(prefab);
			var viewModel = new RoomViewModel(room);
			roomGO.GetComponent<RoomView>().Construct(viewModel);
		}
	}
}