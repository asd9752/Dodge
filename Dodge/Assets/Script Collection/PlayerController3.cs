using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    private Rigidbody PlayerRigidbody2;
    public float speed = 25;


    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)== true)
        {
            PlayerRigidbody2.AddForce(0f, 0f, speed);

        }
        if(Input.GetKey(KeyCode.DownArrow)== true)
        {
            PlayerRigidbody2.AddForce(0f, 0f, -speed);
        }
        if(Input.GetKey(KeyCode.RightArrow)== true)
        {
            PlayerRigidbody2.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
            PlayerRigidbody2.AddForce(-speed, 0f, 0f);

    }
}
