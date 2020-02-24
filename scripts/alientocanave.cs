using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alientocanave : MonoBehaviour
{
    private GameObject nave;
    private GameObject alien;
    private Text cartel;

    private void Start()
    {
        nave = GameObject.FindGameObjectWithTag("Player");
        alien = GameObject.FindGameObjectWithTag("Enemy");
        cartel = GetComponent<texto>().gameover;
    }

   /* private void OnTriggerEnter(Collider alien)
    {
        Destroy(nave);
        Debug.Log("Estas muerto");
    }*/
}
