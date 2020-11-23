using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MovementGrid : MonoBehaviour
{
    public Tilemap walkableTileMap;
    public List<Tilemap> unwalkableTileMaps;
    
    private Pathfinding pathfinding;

    void Awake()
    {
        Vector3 walkableTileTopRight = walkableTileMap.origin + walkableTileMap.size;
        int walkableHeight = Mathf.RoundToInt(walkableTileTopRight.y - walkableTileMap.origin.y);
        int walkableWidth = Mathf.RoundToInt(walkableTileTopRight.x - walkableTileMap.origin.x);

        print("Height: " + walkableHeight + " Width: " + walkableWidth);

        pathfinding = new Pathfinding(walkableWidth, walkableHeight , walkableTileMap.origin);
        pathfinding.RaycastWalkable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
