using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomPreset", menuName = "Scriptable Objects/RoomPreset")]
public class RoomPreset : ScriptableObject
{
    [Header("Basic")]
    public string roomName;

    public RoomType roomType;

    public Vector2Int roomSize;

    [Range(0, 100)]
    public int generationWeight = 10;

    [Header("Doors")]
    public bool allowTopDoor = true;
    public bool allowBottomDoor = true;
    public bool allowLeftDoor = true;
    public bool allowRightDoor = true;

    [Header("Generation")]
    public int minObstacles;
    public int maxObstacles;

    public int minEnemies;
    public int maxEnemies;

    [Header("Prefabs")]
    public List<GameObject> possiblePrefabs;

    public List<GameObject> obstaclePrefabs;

    public List<GameObject> enemyPrefabs;
}
