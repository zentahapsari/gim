﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptball1 : MonoBehaviour
{
    public int speed = 30;
    // public int counter = 0;
    public int counterP1 = 0;
    public int counterP2 = 0;
    public Text scoreText1;
     public Text scoreText2;
    public Rigidbody2D sesuatu;
    public Animator animtr;
    
    // Start is called before the first frame update
    void Start()
    { 
        // scoreText.text = counter.ToString();
        sesuatu.velocity = new Vector2 (-1,-1)*speed;
        animtr.SetBool("IsMove",true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(sesuatu.velocity.x > 0){//bola bergerak ke kanan
        sesuatu.GetComponent<Transform>().localScale = new Vector3(1,1,1);
        }else{ //bola bergerak ke kiri
            sesuatu.GetComponent<Transform>().localScale = new Vector3(-1,1,1);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="DindingKanan"){
            StartCoroutine(jedabolaP1());
            // GetComponent<Transform>().position = new Vector2 (0,0);
        } if (other.collider.name=="DindingKiri"){
            StartCoroutine(jedabolaP2());
        }
    }

    // perintah
    IEnumerator jedabolaP1() {
    sesuatu.velocity = Vector2.zero;
    animtr.SetBool("IsMove",false);
    sesuatu.GetComponent<Transform>().position = Vector2.zero;
    counterP1++;
    scoreText1.text = counterP1.ToString();
    yield return new WaitForSeconds(3);
    sesuatu.velocity = new Vector2 (-1,-1)*speed;
    animtr.SetBool("IsMove",true);
    
    }

    IEnumerator jedabolaP2() {
    sesuatu.velocity = Vector2.zero;
    animtr.SetBool("IsMove",false);
    sesuatu.GetComponent<Transform>().position = Vector2.zero;
    counterP2++;
    scoreText2.text = counterP2.ToString();
    yield return new WaitForSeconds(3);
    sesuatu.velocity = new Vector2 (-1,-1)*speed;
    animtr.SetBool("IsMove",true);
    
    }
    
}
