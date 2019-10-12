using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire1 : MonoBehaviour
{

	public GameObject bulletPrefab;
	public GameObject bulletSpawn;
	public int viedetest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
        	Shoot();
        }

        viedetest = PlayerPrefs.GetInt("Test");
    }

    void Shoot(){
    	var Bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);

    	bulletPrefab.GetComponent<Rigidbody>().velocity = bulletPrefab.transform.forward * 16;
    	Destroy(Bullet, 10.5f);
    }
}

