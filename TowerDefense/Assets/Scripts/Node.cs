using UnityEngine;

public class Node : MonoBehaviour {

    public Color hovercolor;

    private GameObject turret;

    private Renderer rend;

    private Color startColor;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("can't build here");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);

    }

    void OnMouseEnter()
    {
        rend.GetComponent<Renderer>().material.color = hovercolor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
