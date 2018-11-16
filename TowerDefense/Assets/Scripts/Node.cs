using UnityEngine;

public class Node : MonoBehaviour {

    public Color hovercolor;

    private GameObject turret;

    private Renderer rend;

    public PlayerData playerData = new PlayerData();

    private Color startColor;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if (turret != null && playerData.playerPoints >= 500)
        {
            Debug.Log("can't build here");
            return;
        }

        BuildTurret();
        return;

    }

    void BuildTurret()
    {
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
        turret.transform.Translate(Vector3.forward * -0.75f);
        turret.transform.Rotate(-90, 0, 0);
        playerData.playerPoints -= 500;
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
