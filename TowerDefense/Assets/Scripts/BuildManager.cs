
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one BuildManager in Scene");
            return;
        }
        instance = this;
    }

    public GameObject standerdTurretPrefab;

    private void Start()
    {
        turretToBuild = standerdTurretPrefab;
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }
        
}
