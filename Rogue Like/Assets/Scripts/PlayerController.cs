using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // Host fast the player moves
    private float hInput; // Horizontal Input
    private float vInput; // Vertical Input


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = input.GetAxis("Horizontal");
        vInput = input.GetAxis("Vertical")
        
        transform.translate(Vector2.right * hInput * speed * Time.deltaTime); // Move left and right
        transform.translate(Vector2.up * vInput * speed * Time.deltaTime); // Move forward and back
    }
}
