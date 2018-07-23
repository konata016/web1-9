using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour {

    public AudioClip appleSE;
    public AudioClip bombSE;
    AudioSource aud;
    GameObject director;

    void Start()
    {
        this.director = GameObject.Find("GameDirector");
        aud = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("キャッチ");

        if (other.gameObject.tag == "Apple")
        {
            //Debug.Log("Tag=Apple");
            this.director.GetComponent<GameDirector>().GetApple();
            aud.PlayOneShot(appleSE);

            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Bomd")
        {
            //Debug.Log("Tag=Bomb");
            this.director.GetComponent<GameDirector>().GetBomb();
            aud.PlayOneShot(bombSE);
            Destroy(other.gameObject);
        }
    }
}
