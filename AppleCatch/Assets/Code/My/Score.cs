using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text pointText;
    public GameObject Point;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pointText.GetComponent<Text>().text = Point.transform.position.x + "point";
    }
}
