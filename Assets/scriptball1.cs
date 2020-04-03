﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptball1 : MonoBehaviour
{
    public int speed = 30;
    public Rigidbody2D sesuatu;
    public Animator animtr;
    // Start is called before the first frame update
    void Start()
    { 
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
        if(other.collider.name=="DindingKanan"||other.collider.name=="DindingKiri"){
            StartCoroutine(jedabola());
            // GetComponent<Transform>().position = new Vector2 (0,0);
            
        }
    }

    // perintah
    IEnumerator jedabola() {
    sesuatu.velocity = Vector2.zero;
    animtr.SetBool("IsMove",false);
    sesuatu.GetComponent<Transform>().position = Vector2.zero;
    yield return new WaitForSeconds(3);
    sesuatu.velocity = new Vector2 (-1,-1)*speed;
    animtr.SetBool("IsMove",true);
    
    }
    
}
