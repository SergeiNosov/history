using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpawnObjects : MonoBehaviour {

    public GameObject spawnpoint;
    public GameObject spawnButton;
    public GameObject RestartButton;
    public GameObject obj1;
   

	void Start () {

	}
	

	void Update () {
       
	}
    public void SpawnObj()
    {
        GameObject ob1 = Instantiate(obj1, transform.localPosition, Quaternion.identity) as GameObject;
        ob1.transform.position = spawnpoint.transform.position;
        Destroy(spawnpoint);
        spawnButton.SetActive(false);
        RestartButton.SetActive(true);
    }
    public void RestartLvl()
    {
        SceneManager.LoadScene("main");
    }
    public void pushka()
    {
        StartCoroutine(booms());

    }
    public IEnumerator booms()
    {
       
        yield return new WaitForSeconds(3/2);

        GameObject.Find("Ground(Clone)/LPrig/Root/patron4").GetComponent<MeshRenderer>().enabled = false; 
        GameObject.Find("CameraParent/Main Camera").GetComponent<AudioSource>().enabled = true;
        yield return new WaitForSeconds(2/10);
        GameObject.Find("Ground(Clone)/gun/BoomEffect/SmallExplosionEffect").SetActive(true);
        yield return new WaitForSeconds(2);
        GameObject.Find("Ground(Clone)/gun/BoomEffect/SmallExplosionEffect").SetActive(false);
        GameObject.Find("CameraParent/Main Camera").GetComponent<AudioSource>().enabled = false;   
        yield return new WaitForSeconds(1/2);

        GameObject.Find("Ground(Clone)/LPrig/Root/patron4").GetComponent<MeshRenderer>().enabled = true; 
    }
}
