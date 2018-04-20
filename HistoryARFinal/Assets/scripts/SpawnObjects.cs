using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpawnObjects : MonoBehaviour {

    public GameObject spawnpoint;
    public GameObject spawnButton;
    public GameObject RestartButton;
    public GameObject obj1;
    public AudioSource gun;

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
        gun.enabled = true; 
        yield return new WaitForSeconds(2);
        gun.enabled = false;   

    }
}
