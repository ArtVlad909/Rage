using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour{
	public int mun;
    public int GunMun;
	public int AmmoReaming;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
		if(col.tag == "Player"){
			AmmoReaming = PlayerPrefs.GetInt("YellowGunAmmo");
    		GunMun = mun + AmmoReaming;
    		PlayerPrefs.SetInt("YellowGunAmmo", GunMun);
			Destroy(gameObject);
		}
    	
    }
}
