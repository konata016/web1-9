﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour {

    public AudioClip appleSE;
    public AudioClip bombSE;
    AudioSource aud;
    GameObject director;

	// Use this for initialization
	void Start () {
        this.director = GameObject.Find("GameDirector");
        aud = GetComponent<AudioSource>();
	}
	 private void OnTriggerEnter(Collider other)
    {
        Debug.Log("キャッチ");

        if (other.gameObject.tag == "Apple")
        {
            //Debug.Log("Tag=Apple");
            this.director.GetComponent<GameDirector>().GetApple();
            aud.PlayOneShot(appleSE);
        }
        else
        {
            //Debug.Log("Tag=Bomb");
            this.director.GetComponent<GameDirector>().GetBomb();
            aud.PlayOneShot(bombSE);
        }
        Destroy(other.gameObject);
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                float x=Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
	}

   
}
