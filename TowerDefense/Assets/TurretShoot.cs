using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//var Enemies : List.<GameObject>;  nog enemies maken

public class TurretShoot : MonoBehaviour {

    var Bullet : GameObject;
    var ShootCooldownLeft : float;
    var ShootSpeed : float;
    var Target : GameObject;

    // Use this for initialization
    void Start () {
        //Enemies = new List.< GameObject.();
	}
	
	// Update is called once per frame
	void Update () {
        ShootCooldownLeft -= Time.deltaTime;

        if (ShootCooldownLeft <= 0 )
        {
            var clone = Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), Quaternion.identity);
            clone.transform.parent = this.transform;
            ShootCooldownLeft = ShootSpeed;
        }
	}
}
