using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGun : MonoBehaviour {

	
	void Start () {
		
	}
	
	
	void Update () {
		
	}
    public void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("pul"))
        {
            GameObject.Find("Manager").GetComponent<SpawnObjects>().pushka();
        }
    }
}
