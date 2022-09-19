using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController4 : MonoBehaviour
{
    private Rigidbody CubeRigdibody;
    public float speed = 20f;
   

    // Start is called before the first frame update
    void Start()
    {
        CubeRigdibody=GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");
        
        float xSpeed = speed * xinput;
        float zSpeed = speed * zinput;

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            CubeRigdibody.AddForce(0f, 50*speed, 0f);
        }

        Vector3 Controll = new Vector3(xSpeed, 0f, zSpeed);
        CubeRigdibody.velocity = Controll;
    }
}
