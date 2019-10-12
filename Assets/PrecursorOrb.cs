using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrecursorOrb : MonoBehaviour
{

	public int Orbs;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
		Orbs = PlayerPrefs.GetInt("PrecursorOrbs");
    }

	void OnTriggerEnter(Collider col){
		if(col.tag == "Player"){
			Orbs++;
			PlayerPrefs.SetInt("PrecursorOrbs", Orbs);
			Destroy(gameObject);
		}
	}
}
