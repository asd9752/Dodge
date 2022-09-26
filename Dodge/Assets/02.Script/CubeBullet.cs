using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBullet : MonoBehaviour
{

    private Rigidbody cuberigidbody;
    public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        cuberigidbody=GetComponent<Rigidbody>();
        cuberigidbody.velocity = transform.forward * speed;
        Destroy(gameObject,4f);

    }


    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag =="Player")
        {
            PlayerController4 playerController = other.GetComponent<PlayerController4>();
            if(playerController != null)
            {
                playerController.Die();
            }


        }



    }
}
