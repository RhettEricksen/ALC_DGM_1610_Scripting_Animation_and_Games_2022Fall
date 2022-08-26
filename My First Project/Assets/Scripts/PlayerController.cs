using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{   
    // Access Mod, Data Type, Name ;
    public float speed; // set speed value
    public float rotSpeed; // Rotation Speed
    public float hInput; // horizontal input
    public float vInput; // vertical input

    // Update is called once per frame
    void Update()
    {   
        // Collect Input values from keyboard
        hInput = input.Getaxis("horizontal");
        vInput = input.Getaxis("vertical"); 

        // Move the character around
        transform.Rotate(vector3.up, rotSpeed * hInput * Time.deltaTime);// Rotate Left and Right

        transform.Translate(vector3.forward * speed * vInput  * Time.deltaTime);//Foward and Backward movement
    }
}
