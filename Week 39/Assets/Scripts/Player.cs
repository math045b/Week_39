using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
        if(Input.GetKeyDown("space")){
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
