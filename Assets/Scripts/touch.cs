using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class touch : MonoBehaviour
{

    public GameObject start;
    public static float Timer;

    void Awake()
    {
        Time.timeScale=0;
    }
    // Start is called before the first frame update
    void Start()
    {
        start.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        //print (Timer);

        if (Input.GetKeyDown (KeyCode.Space)){

        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 20));
        start.SetActive(false);
        Time.timeScale=1;

        }

/*        if (Input.GetKeyDown (KeyCode.A)){

          if (Advertisement.IsReady())
          {
              Advertisement.Show("video");
          }

        }*/

        if (Input.touchCount > 0){

        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10));
        start.SetActive(false);
        Time.timeScale=1;
    }
    }
}
