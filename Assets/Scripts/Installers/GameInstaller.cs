using Zenject;

// Installer: Binds core services and ViewModels for dependency injection
public class GameInstaller : MonoInstaller
{
	public override void InstallBindings()
	{
		// Bind singletons
		Container.Bind<RoomManager>().AsSingle();
		Container.Bind<ProceduralGenerator>().AsSingle();
		Container.Bind<RoomLoader>().AsSingle();
		Container.Bind<SaveLoadService>().AsSingle();
		// Bind ViewModels as transient (new instance per injection)
		Container.Bind<RoomViewModel>().AsTransient();
	}
}