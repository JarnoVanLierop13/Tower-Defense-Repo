using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMaster : MonoBehaviour {

    public int xSize = 10;
    public int ySize = 10;

    public int[,] gridPreset = new int[10, 10]
    {
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
        { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0 },
        { 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
        { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
    };

    [SerializeField]
    private GameObject cubeHolder;
    private GameObject[] cubes;
    private Color greenTile = new Color32(14, 132, 34, 255);
    private Color brownTile = new Color32(120, 67, 6, 255);


    private void CreateGrid(int x, int y)
    {
        GridSystem myGrid = new GridSystem(x, y);
        int positionX = 0;
        int positionY = 0;
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                GenerateTiles(positionY, positionX, gridPreset[i, j]);
                positionX += 1;
            }
            positionX = 0;
            positionY += 1;
        }
    }

    private void Awake()
    {
        ClearMap();
        CreateGrid(xSize, ySize);
    }

    void ClearMap()
    {
        cubes = GameObject.FindGameObjectsWithTag("GreenTile");
        for (var i = 0; i < cubes.Length; i++)
        {
            DestroyImmediate(cubes[i]);
        }

        cubes = GameObject.FindGameObjectsWithTag("BrownTile");
        for (var i = 0; i < cubes.Length; i++)
        {
            DestroyImmediate(cubes[i]);
        }
    }

    private void GenerateTiles(int i, int j, int gridSize)
    {
        if (gridSize == 1)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.GetComponent<Renderer>().material.color = brownTile;
            cube.name = "Brown Tile";
            cube.tag = "BrownTile";
            cube.transform.position = new Vector3(j, i, 1);
            cube.transform.parent = cubeHolder.transform;
        }
        else if (gridSize == 0)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.AddComponent<Node>();
            cube.GetComponent<Renderer>().material.color = greenTile;
            cube.name = "Green Tile";
            cube.tag = "GreenTile";
            cube.transform.position = new Vector3(j, i, 1);
            cube.transform.parent = cubeHolder.transform;
        }
    }

    }
