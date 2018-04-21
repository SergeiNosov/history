using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {
    public Camera camerapos;
    public GameObject patronsGet;
    public GameObject ButtonGET;

    public GameObject binButton;
    public GameObject CanStar;
    public GameObject Canbin;
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
                binButton.SetActive(false);
            } 
          
            if(objectHit.name == "binokol")
            {
                binButton.SetActive(true);
                ButtonGET.SetActive(false);
            }
        }
        else {
      
            ButtonGET.SetActive(false);
            binButton.SetActive(false);
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
    public void binokol()
    {
        CanStar.SetActive(false);
        Canbin.SetActive(true);
    }
    public void Back()
    {
        CanStar.SetActive(true);
        Canbin.SetActive(false);  
    }
}
