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
        //������� �������� �Է°��� �����Ͽ� ����
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");

        //�����̵��ӵ��� �Է°��� �̵��ӷ��� ����� ����
        float xSpeed = xinput * speed;
        float zSpeed = zinput * speed;

        //Vector3 �ӵ��� (xSpeed,0,zSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }
}
