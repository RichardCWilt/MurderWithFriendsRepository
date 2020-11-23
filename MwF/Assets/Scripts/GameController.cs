using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject playerPrefab;

    [SerializeField]
    private GameObject startingPoint;

    private Pathfinding pathfinding;

    void Start()
    {
        // Spawn the player character to the chosen starting point
        pathfinding = Pathfinding.Instance;
        pathfinding.GetGrid().GetXY(startingPoint.transform.position, out int x, out int y);
        print("X: " + x + " Y: " + y);
        Instantiate(playerPrefab, pathfinding.GetGrid().GetWorldPosition(x, y) + new Vector3(pathfinding.GetGrid().GetCellSize(), pathfinding.GetGrid().GetCellSize()) * 0.5f, Quaternion.identity);
    }

}
