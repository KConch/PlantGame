using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rigbod;



    // Start is called before the first frame update
    void Start()
    {
        rigbod = GetComponent<Rigidbody2D>();


    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rigbod.AddForce(movement * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
