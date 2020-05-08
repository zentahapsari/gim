using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptball1 : MonoBehaviour
{
    public AudioSource myFX;
    // public int speed = 30;
    // public int counter = 0;
    public static int counterP1 = 0; // ternyata dengan menambahkan static ketika game di play sekali dalam unity,
                                    // lalu di sediakan tombol mulai lagi di ending scene
                                    // yang terjadi ketika tombol mulai lagi diklik yaitu, scorenya tidak mulai dari nol
                                    // dan malah melanjutkan total score di permainan sebelumnya.
    public static int counterP2 = 0;
    public Text scoreText1;
    public Text scoreText2;
    public Rigidbody2D sesuatu;
    public Animator animtr;
    
    // Start is called before the first frame update
    void Start()
    { 
        int x = Random.Range(0,2)*2 - 1; //nilai x bisa bernilai -1 atau 1
        int y = Random.Range(0,2)*2 - 1; //nilai x bisa bernilai -1 atau 1
        int speed = Random.Range(20,26); // nilai speed antara so sampai 25
        sesuatu.velocity = new Vector2 (x,y)*speed;
        sesuatu.GetComponent<Transform>().position = Vector2.zero;
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
        if(other.collider.tag == "Player"){
            myFX.Play();
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

    int x = Random.Range(0,2)*2 - 1;
    int y = Random.Range(0,2)*2 - 1;
    int speed = Random.Range(20,26); // nilai speed antara so sampai 25
    sesuatu.velocity = new Vector2 (x,y)*speed;
    animtr.SetBool("IsMove",true);
    
    }

    IEnumerator jedabolaP2() {
    sesuatu.velocity = Vector2.zero;
    animtr.SetBool("IsMove",false);
    sesuatu.GetComponent<Transform>().position = Vector2.zero;
    counterP2++;
    scoreText2.text = counterP2.ToString();

    yield return new WaitForSeconds(3);
    
    int x = Random.Range(0,2)*2 - 1;
    int y = Random.Range(0,2)*2 - 1;
    int speed = Random.Range(20,26); // nilai speed antara so sampai 25
    sesuatu.velocity = new Vector2 (x,y)*speed;
    animtr.SetBool("IsMove",true);
    
    }
    
}
