using System.Collections.Generic;
using UnityEngine;

// Core: Handles procedural generation of rooms
public class ProceduralGenerator
{
	public List<RoomModel> GenerateRooms(int roomCount)
	{
		var rooms = new List<RoomModel>();
		// Simple example: generate rooms in a grid
		for(int i = 0; i < roomCount; i++)
		{
			var position = new Vector2Int(i % 5, i / 5);
			rooms.Add(new RoomModel(i, position));
		}
		// Connect rooms, etc.
		return rooms;
	}
}