using System.IO;
using Newtonsoft.Json;
using UnityEngine;

// Service: Handles saving and loading game data using JSON
public class SaveLoadService
{
	private string SavePath => Path.Combine(Application.persistentDataPath, "save.json");

	public void Save(GameSaveData data)
	{
		var json = JsonConvert.SerializeObject(data, Formatting.Indented);
		File.WriteAllText(SavePath, json);
	}

	public GameSaveData Load()
	{
		if(!File.Exists(SavePath))
			return null;

		var json = File.ReadAllText(SavePath);
		return JsonConvert.DeserializeObject<GameSaveData>(json);
	}
}