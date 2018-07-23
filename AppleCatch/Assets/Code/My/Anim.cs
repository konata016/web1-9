using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{

    public Rigidbody rb;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Running", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("Running", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Running", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
        }
    }
}