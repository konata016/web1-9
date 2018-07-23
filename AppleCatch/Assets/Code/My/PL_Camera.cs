using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL_Camera : MonoBehaviour {

    public GameObject PL;


    // Use this for initialization
    void Start()
    {
        gameObject.transform.Rotate(20, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camera = transform.position;

        camera.x = PL.transform.position.x;
        camera.y = PL.transform.position.y + 5f;
        camera.z = PL.transform.position.z - 1.6f;

        transform.position = camera;

    }
}
