using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{

	public GameObject YelowMun;
	public GameObject Create;
	public Transform ToSpawn;
	public Transform ToSpawn2;
	public Transform ToSpawn3;
	public Transform ToSpawn4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter(){
		Instantiate(YelowMun, ToSpawn.position, ToSpawn.rotation);
		Instantiate(YelowMun, ToSpawn2.position, ToSpawn2.rotation);
		Instantiate(YelowMun, ToSpawn3.position, ToSpawn3.rotation);
		Instantiate(YelowMun, ToSpawn4.position, ToSpawn4.rotation);
		Destroy(Create);
	}
}
