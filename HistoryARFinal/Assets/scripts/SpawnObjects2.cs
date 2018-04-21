using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpawnObjects2 : MonoBehaviour {

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
 

  
}
