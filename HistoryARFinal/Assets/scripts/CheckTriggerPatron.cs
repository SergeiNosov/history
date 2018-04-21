using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTriggerPatron : MonoBehaviour {
    public bool checksactive;
	// Use this for initialization
	void Start () {
        checksactive = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider patron)
    {
        
        if(patron.CompareTag("pul") & checksactive==false)
        {
            checksactive = true;
           // GameObject.Find("CameraParent/Main Camera").GetComponent<Raycast>().patronsGet.SetActive(false);
            StartCoroutine(booms());

        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("pul")& checksactive)
        {
            checksactive = false;
        }
    }
    public IEnumerator booms()
    {
        GameObject.Find("CameraParent/Main Camera").GetComponent<Raycast>().patronsGet.SetActive(false);
        yield return new WaitForSeconds(5);


        GameObject.Find("CameraParent/Main Camera").GetComponent<AudioSource>().enabled = true;
        GameObject.Find("GroundGO(Clone)/gun/BoomEffect/SmallExplosionEffect").SetActive(true);
       yield return new WaitForSeconds(2);

        GameObject.Find("GroundGO(Clone)/gun/BoomEffect/SmallExplosionEffect").SetActive(false);
        GameObject.Find("CameraParent/Main Camera").GetComponent<AudioSource>().enabled = false;
      
    }
}
