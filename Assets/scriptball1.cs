using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptball1 : MonoBehaviour
{
    public int speed = 30;
    // Start is called before the first frame update
    void Start()
    { 
        GetComponent<Rigidbody2D>().velocity = new Vector2 (2,1)*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="DindingKanan"||other.collider.name=="DindingKiri"){
            StartCoroutine(jedabola());
            // GetComponent<Transform>().position = new Vector2 (0,0);
            
        }
    }

   


    // perintah
    IEnumerator jedabola() {
    GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    GetComponent<Transform>().position = new Vector2 (0,0);
    yield return new WaitForSeconds(3);
    Start();
    
    }
    
}
