using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reload : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadScene(string nameScene){
        touch.Timer = 0f;
        SceneManager.LoadScene(nameScene);
    }
}
