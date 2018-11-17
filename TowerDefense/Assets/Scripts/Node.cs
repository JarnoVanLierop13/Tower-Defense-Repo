using UnityEngine;

public class Node : MonoBehaviour {

    public Color hovercolor;

    private GameObject turret;

    private Renderer rend;

    public PlayerData playerData;

    private Color startColor;

    private void Start()
    {
        GameObject gameManagerObj = GameObject.Find("Managers/GameManager");
        GameManagerNew gameManagerNew = gameManagerObj.GetComponent<GameManagerNew>();
        playerData = gameManagerNew.playerData;

        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if (turret == null && playerData.playerPoints >= 500)
        {
            BuildTurret();
            return;
        }
        return;

    }

    void BuildTurret()
    {
        playerData.playerPoints -= 500;
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
        turret.transform.Translate(Vector3.forward * -0.75f);
        turret.transform.Rotate(-90, 0, 0);
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
