using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class movroket : MonoBehaviour
{
   public float velocidad; //esta es la variable para el dato de velocidad

    // Update is called once per frame
    void Update()
    {
        MovRoket();
    }

    void MovRoket()
    {
        float InputMov =Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(InputMov * velocidad, inputVertical * velocidad);
       
    }
}
