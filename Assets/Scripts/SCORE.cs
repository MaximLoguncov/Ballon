using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SCORE : MonoBehaviour {

        public Text score; // Создаетет UI текст пустой и прикрепляете сюда.
        public Text scoreEnd;

        
    
       
        // Update is called once per frame
        void Update () {
                score.text = " " + touch.Timer; // Это присваивает вашему тексту значение переменной 
                scoreEnd.text = "Distance covered: " + touch.Timer + " meters";
        }
}