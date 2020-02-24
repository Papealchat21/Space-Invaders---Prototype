using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bordedestructor : MonoBehaviour
{
    //
    public GameObject bala;
    public GameObject nave;
    playercontroller1 disparohecho;

    private void Start()
    {
        //bala = GameObject.FindGameObjectWithTag("Disparo");
        disparohecho = nave.GetComponent<playercontroller1>();
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        disparohecho.shot = 0;
    }
}
