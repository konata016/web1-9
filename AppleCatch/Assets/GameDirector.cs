using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject timerText;
    GameObject pointText;
    float time = 60.0f;
    int point = 0;

	// Use this for initialization
	void Start () {
        timerText = GameObject.Find("Item");
        pointText = GameObject.Find("Point");

    }
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        timerText.GetComponent<Text>().text = time.ToString("F1");
        pointText.GetComponent<Text>().text = point.ToString() + "point";
    }

    public void GetApple()
    {
        this.point += 100;
    }
    public void GetBomb()
    {
        this.point /= 2;
    }
}
