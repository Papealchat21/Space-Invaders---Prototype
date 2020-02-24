using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class balatocaalien : MonoBehaviour
{
    public GameObject alien;
    public Text cartel;
    //public GameObject bala;
    playercontroller1 disparohecho = new playercontroller1();

    private void Start()
    {
        alien = GameObject.FindGameObjectWithTag("Enemy");
        cartel = GetComponent<texto2>().winner;
        //bala = GameObject.FindGameObjectWithTag("Disparo");
    }

    private void OnTriggerEnter(Collider other)
    {
        disparohecho.shot = 0;
        Destroy(alien);
        Destroy(other.gameObject);
        Debug.Log("Alien muerto");
        cartel.enabled = true;
    }
}
