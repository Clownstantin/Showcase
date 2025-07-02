using UniRx;
using UnityEngine;

// View: MonoBehaviour that binds to ViewModel and updates visuals
public class RoomView : MonoBehaviour
{
	private RoomViewModel _viewModel;
	private CompositeDisposable _disposables = new();

	// Called by Zenject or manually to inject the ViewModel
	public void Construct(RoomViewModel viewModel)
	{
		_viewModel = viewModel;
	}

	private void Start()
	{
		// Bind to ViewModel properties
		if(_viewModel != null)
		{
			_viewModel.Room.Subscribe(UpdateRoomVisuals).AddTo(_disposables);
			_viewModel.OnEnterRoom.Subscribe(_ => PlayEnterAnimation()).AddTo(_disposables);
		}
	}

	private void UpdateRoomVisuals(RoomModel model)
	{
		// Update visuals based on model data (e.g., position, type)
	}

	private void PlayEnterAnimation()
	{
		// Play animation when entering room
	}

	private void OnDestroy() => _disposables.Dispose();
}