﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathNode 
{
    private Grid<PathNode> grid;
    private int x;
    private int y;

    public int X { get { return x; } }
    public int Y { get { return y; } }

    public int gCost;
    public int hCost;
    public int fCost;

    public bool isWalkable;
    public PathNode cameFromNode;

    public PathNode(Grid<PathNode> grid, int x, int y)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
        this.isWalkable = true;
    }

    public void CalculateFCost()
    {
        fCost = gCost + hCost;
    }


    public void SetIsWalkable(bool isWalkable)
    {
        this.isWalkable = isWalkable;
    }

    public override string ToString()
    {
        return x + "," + y;
    }
}
