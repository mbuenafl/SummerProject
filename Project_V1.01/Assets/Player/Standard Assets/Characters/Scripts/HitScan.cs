using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScan : MonoBehaviour {
    //Melee attack range
    public float meleeRange = 10f;
    public GameObject sword;

    //Get the camera that is going to be used 
    private Camera fpsCam;

	// Use this for initialization
	void Start () {
        fpsCam = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () { 

        //Any input that is a fire trigger
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 screenMiddle = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            RaycastHit meleeHit;

            if(Physics.Raycast(screenMiddle, fpsCam.transform.forward, out meleeHit, meleeRange))
            {
                if(meleeHit.collider.tag == "Enemy")
                {
                    //Do what ever needs to happen to the enemy

                    Debug.Log("Hit an Enemy");
                }
            }
        }
	}
}
