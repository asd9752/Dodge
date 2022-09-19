using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody; 
    
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
    }

}
