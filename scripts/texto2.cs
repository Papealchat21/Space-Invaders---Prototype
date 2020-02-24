using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texto2 : MonoBehaviour
{

    public Text winner;

    public void Start()
    {

        winner = GetComponent<Text>();
        winner.enabled = false;


    }

}
