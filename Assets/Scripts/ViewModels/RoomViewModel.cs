using UniRx;

// ViewModel: Exposes observable properties and commands for the View
public class RoomViewModel
{
	public ReactiveProperty<RoomModel> Room { get; }
	public ReactiveCommand OnEnterRoom { get; }

	public RoomViewModel(RoomModel model)
	{
		Room = new ReactiveProperty<RoomModel>(model);
		OnEnterRoom = new ReactiveCommand();
		OnEnterRoom.Subscribe(_ => HandleEnterRoom());
	}

	private void HandleEnterRoom()
	{
		// Logic when player enters the room (e.g., spawn enemies, play sound)
	}
}