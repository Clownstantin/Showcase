using System.Collections.Generic;
using UnityEngine;

public class RoomModel
{
	public int RoomId { get; }
	public Vector2Int Position { get; }
	public List<int> ConnectedRoomIds { get; }

	public RoomModel(int roomId, Vector2Int position)
	{
		RoomId = roomId;
		Position = position;
		ConnectedRoomIds = new List<int>();
	}
}