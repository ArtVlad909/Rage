	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowGun : MonoBehaviour
{
	public GameObject Bullet;
	public GameObject EcoGunAmmo;
	public GameObject EcoGunDeco;
	public GameObject EcoGun;
	public Transform Pos1;
	public int Ammo;
	public int AmmoGun;
	public int AmmoMax;
	public bool Gun = false;
	public float Speed;

    // Start is called before the first frame update
    void Start()
    {
		Ammo = PlayerPrefs.GetInt("YellowGunAmmo");
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetMouseButton(1)){
           if(Ammo == 0){
			print("No Mun");
		   }
		   else{
			  Shoot();
			  print("Fire");
			  Ammo--;
			  PlayerPrefs.SetInt("YellowGunAmmo", Ammo);
		   }		   
        }

		if(Ammo == 100){
			Ammo = 100;
			PlayerPrefs.SetInt("YellowGunAmmo", 100);
		}
    }

    void Shoot(){
		Bullet.transform.position = Pos1.transform.position;
		PlayerPrefs.SetInt("YellowGunAmmo", Ammo);
        print("Feu");
    }
}
