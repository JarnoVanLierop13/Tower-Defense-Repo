using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {

    public static Transform[] locations;

    private void Awake()
    {
        locations = new Transform[transform.childCount];
        for (int i = 0; i < locations.Length; i++)
        {
            locations[i] = transform.GetChild(i);
        }
    }

}
