using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {
    public Camera camerapos;
    public GameObject patronsGet;
    public GameObject ButtonGET;
    public GameObject ButtonTake;

 
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = camerapos.ScreenPointToRay(new Vector3(camerapos.pixelWidth / 2, camerapos.pixelHeight / 2, 0));
        RaycastHit hit;
        Debug.DrawRay(ray.GetPoint(0f), Vector3.forward * 1f, Color.yellow);
        if (Physics.Raycast(ray, out hit, 15f))
        {
            GameObject objectHit = GameObject.Find(hit.transform.name);
            if (objectHit.name == "patron2") 
            {
                ButtonGET.SetActive(true);
            } 
            if(objectHit.name == "Trigger" & patronsGet.activeSelf)
            {
                ButtonTake.SetActive(true);
            }

        }
        else {
            ButtonTake.SetActive(false);
            ButtonGET.SetActive(false);
        }
	}

    public void GetP()
    {
        patronsGet.SetActive(true);
     
    }
    public void TakeP()
    {
        
        GameObject.Find("GroundGO(Clone)/patron3").SetActive(true);



    }
}
