using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GridMaster : MonoBehaviour {

    public int xSize = 10;
    public int ySize = 10;

    

    private GameObject[] cubes;
    private Color greenTile = new Color32(14, 132, 34, 255);
    private Color brownTile = new Color32(120, 67, 6, 255);


    private void CreateGrid(int x, int y)
    {
        GridSystem myGrid = new GridSystem(x, y);

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.GetComponent<Renderer>().sharedMaterial.color = greenTile;
                cube.tag = "MapTile";
                cube.transform.position = new Vector3(i, j, 0);
            }
        }
    }

    private void Awake()
    {
        ClearMap();
        CreateGrid(xSize, ySize);
    }

    void ClearMap()
    {
        cubes = GameObject.FindGameObjectsWithTag("MapTile");

        for (var i = 0; i < cubes.Length; i++)
        {
            DestroyImmediate(cubes[i]);
        }
    }

}
