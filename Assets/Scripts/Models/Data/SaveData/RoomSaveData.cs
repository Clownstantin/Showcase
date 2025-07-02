using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct RoomSaveData
{
	public List<RoomModel> Rooms;
	public Vector2 PlayerPosition;
}
