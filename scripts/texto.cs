using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class texto : MonoBehaviour
{

    public Text gameover;
    
    public Transform enemige;

    // Start is called before the first frame update
    public void Start()
    {

        gameover = GetComponent<Text>();
        gameover.enabled = false;
     
      
      

    }

    private void Update()
    {

        if (enemige.position.y <= 2)
        {

            gameover.enabled = true;

        }

    }



}
