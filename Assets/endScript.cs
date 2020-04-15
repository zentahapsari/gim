using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScript : MonoBehaviour
{
    public Text resultText;
    // public int scoreText1 = 0, scoreText2=0;
    // Start is called before the first frame update
    void Start()
    {
        if(scriptball1.counterP1>scriptball1.counterP2){
            resultText.text = "Player 1 Menang !";
        } else if (scriptball1.counterP1<scriptball1.counterP2){
            resultText.text = "Player 2 Menang !";
        } else {
            resultText.text = "Keduanya Menang !";
        }
    }

}
