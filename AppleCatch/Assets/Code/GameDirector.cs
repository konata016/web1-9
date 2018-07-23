using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    GameObject timerText;
    GameObject pointText;
    public GameObject my;
    float time = 30.0f;
    float point = 0f;
    GameObject generator;

	// Use this for initialization
	void Start () {
        generator = GameObject.Find("ItemGenerator");
        timerText = GameObject.Find("Item");
        pointText = GameObject.Find("Point");

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.GetComponent<Text>().text = time.ToString("F1");
        pointText.GetComponent<Text>().text = point.ToString() + "point";


        if (time < 0)
        {
            time = 0;
            generator.GetComponent<ItemGenerator>().SetParameter(10000.0f, 0, 0);
        }
        else if (0 <= time && time < 5)
        {
            generator.GetComponent<ItemGenerator>().SetParameter(0.9f, -0.04f, 3);
        }
        else if (0 <= time && time < 10)
        {
            generator.GetComponent<ItemGenerator>().SetParameter(0.4f, -0.06f, 6);
        }
        else if (0 <= time && time < 20)
        {
            generator.GetComponent<ItemGenerator>().SetParameter(0.7f, -0.04f, 4);
        }
        else if (0 <= time && time < 30)
        {
            generator.GetComponent<ItemGenerator>().SetParameter(1.0f, -0.03f, 2);
        }

        my.transform.SetPositionAndRotation(new Vector3(point, 0, 0), my.transform.rotation);

        if (time == 0)
        {
            SceneManager.LoadScene("Score");
        }
    }

    public void GetApple()
    {
        this.point += 100f;
    }
    public void GetBomb()
    {
        this.point /= 2f;
    }
   
}
