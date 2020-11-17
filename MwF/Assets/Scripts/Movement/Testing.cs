using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Lumin;

public class Testing : MonoBehaviour
{
    // private Grid<bool> grid;
    private Pathfinding pathfinding;

    private void Start()
    {
        pathfinding = new Pathfinding(10, 10, Vector3.zero);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pathfinding.GetGrid().GetXY(worldPosition, out int x, out int y);
            List<PathNode> path = pathfinding.FindPath(0, 0, x, y);
            if (path != null)
            {
                for (int i=0; i<path.Count - 1; i++)
                {
                    print(worldPosition);
                    Debug.DrawLine(new Vector3(path[i].X, path[i].Y) + Vector3.one * 0.5f , new Vector3(path[i + 1].X, path[i + 1].Y)  + Vector3.one * 0.5f , Color.green, 5f);
                }
            }
        }
    }






   /* private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            int value = grid.GetValue(worldPosition);
            grid.SetValue(worldPosition, value + 5);
        }
    }*/



    // This update makes is so that when you left click the tile you change the valeu within the tile to 0 and when you right click it will relay the value to the log
    // This can be used to understand in the future how to be able to click the grid to get information
    /*    private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                grid.SetValue(worldPosition, 56);
            }

            if (Input.GetMouseButtonDown(1))
            {
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Debug.Log(grid.GetValue(worldPosition));
            }
        }*/
}
