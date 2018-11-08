using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GridMaster : MonoBehaviour {

    private void CreateGrid(int x, int y)
    {
    
    GridSystem myGrid = new GridSystem(x, y);
        Debug.Log(myGrid);

    }

    private void Awake()
    {
        CreateGrid(10, 10);
    }

}
