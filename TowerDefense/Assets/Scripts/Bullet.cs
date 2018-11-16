using UnityEngine;

public class Bullet : MonoBehaviour {

    private Transform target;

    public float speed = 70f;
    private Enemy enemyAccess;

    private void Awake()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemyAccess = enemy.GetComponent<Enemy>();
    }

    public void Seek(Transform _target)
    {
        target = _target;
    }
        
	
	// Update is called once per frame
	void Update () {

        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distancethisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distancethisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distancethisFrame, Space.World);
           
	}

    void HitTarget()
    {
        enemyAccess.enemyHP -= GetRandomNumber(29, 41);
        Destroy(gameObject);   
    }

    private int GetRandomNumber(int lowestNumber, int highestNumber)
    {
        int randomNumber = Random.Range(lowestNumber, highestNumber);
        return randomNumber;
    }
}
