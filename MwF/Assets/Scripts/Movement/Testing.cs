using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Lumin;

public class Testing : MonoBehaviour
{
    private Grid<bool> grid;

    private void Start()
    {
        // grid = new Grid<bool>(20 , 10, 1f, Vector3.zero);
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
