using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    
    public float speed;
    public Transform enemigo;
    private GameObject cuerpoenemigo;
    private GameObject nave;
    private GameObject barrera;
    //private Text letrero;
    

    void Start()
    {
        InvokeRepeating("MoveEnemy", 0.3f, 0.3f);

        cuerpoenemigo = GameObject.FindGameObjectWithTag("Enemy");
        enemigo = GetComponent<Transform>();
        nave = GameObject.FindGameObjectWithTag("Player");
        barrera = GameObject.FindGameObjectWithTag("Finish");


    }

    // Update is called once per frame
    public void MoveEnemy()
    {

        enemigo.position += Vector3.right * speed;
        //Debug.Log("hola me muevo");

       

            if(enemigo.position.x >6 || enemigo.position.x<-6)
            {

                speed = -speed;
                enemigo.position += Vector3.down * 2f;
                speed = speed * 1.2f;
                //el cohete acelera al llegar al borde
                Debug.Log("llega al borde y baja");
                return;

            }
            
            if(enemigo.position.y <= 2)
            {
            Destroy(nave);
            Destroy(cuerpoenemigo);
            Destroy(barrera);            
            }
    }

}

