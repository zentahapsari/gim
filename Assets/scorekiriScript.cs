using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scorekiriScript : MonoBehaviour
{
    public int counterP1 = 0;
    public int counterP2 = 0;
    public Text score1Text;
    public Text score2Text;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        score1Text.text = counterP1.ToString();
        score2Text.text = counterP2.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
  
        
    }

    void player1Score(){
        counterP1++;
        score1Text.text = counterP1.ToString();
    }

    void player2Score(){
        counterP2++;
        score2Text.text = counterP2.ToString();
    }

      
}
