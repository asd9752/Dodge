using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll2 : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //수평축과 수직축의 입력값을 감지하여 저장
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");

        //실제이동속도를 입력값과 이동속력을 사용해 결정
        float xSpeed = xinput * speed;
        float zSpeed = zinput * speed;

        //Vector3 속도를 (xSpeed,0,zSpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //리지드바디의 속도에 newVelocity 할당
        playerRigidbody.velocity = newVelocity;
    }
}
