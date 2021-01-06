using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class collider : MonoBehaviour
{
    public GameObject end;

void Start (){

    end.SetActive(false);

    if (Advertisement.isSupported)
    {
      Advertisement.Initialize("3964688");
    }

}

    void OnCollisionEnter2D (Collision2D other){
        print (other.gameObject.name);
        print (touch.Timer);
        end.SetActive(true);
        Time.timeScale = 0;

        if (Advertisement.IsReady())
        {
            Advertisement.Show("video");
        }

    }
}
