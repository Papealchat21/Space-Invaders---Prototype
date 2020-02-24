using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparos : MonoBehaviour
{
    private Rigidbody rigrayo;
    public float speed;

    private void Awake()
    {
        rigrayo = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rigrayo.velocity = transform.up * speed;
    }

}
