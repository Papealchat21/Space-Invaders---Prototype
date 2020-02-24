using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller1 : MonoBehaviour
{
    public float velocidad;
    private Rigidbody nave;

    public GameObject disparo;
    public Transform spawndisparo;
    public float timeentredisparos;
    private float timedisparo;
    public int shot = 0;



    void Awake()
    {
        nave = GetComponent<Rigidbody>();
    }



    private void Update()
    {
        if (Input.GetButton("Jump") && shot == 0)
        {
            Instantiate(disparo, spawndisparo.position, spawndisparo.rotation);
            shot = 1;
        }
    }

    void FixedUpdate()
    {
        float movhorizontal = Input.GetAxis("Horizontal");

        Vector3 movimiento = new Vector3(movhorizontal, 0f, 0f);
        nave.velocity = movimiento * velocidad;
        nave.position = new Vector3(Mathf.Clamp(nave.position.x, -6, 6), 0f, 0f);
    }
}
