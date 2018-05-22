using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordScript : MonoBehaviour
{

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            anim.SetBool("swing", true);
        }
        else{
            anim.SetBool("swing", false);
        }
    }
}
