using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float ordinat;
    float hori;
    public float speed = 5f;
    public Animator anim;
    
    

    void Start()
    {

    }


    void Update()
    {
        Hareket();
        

        
    }

    private void Hareket()
    {
        ordinat = Input.GetAxis("Vertical");
        hori = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hori, ordinat, 0) * speed * Time.deltaTime;

        if (hori < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            anim.SetBool("isRun", true);

        }
        else if (hori == 0)
        {
            anim.SetBool("isRun", false);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            anim.SetBool("isRun", true);
        }
        if (ordinat < 0)
        {
            anim.SetBool("isRun2", true);
        }
        else if (ordinat == 0)
        {
            anim.SetBool("isRun2", false);
        }
        else
        {
            anim.SetBool("isRun2", true);
        }
       
    }
}

