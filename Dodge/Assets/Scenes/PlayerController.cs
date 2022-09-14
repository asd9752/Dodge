using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {   //���ʹ���Ű �Է��� ������ ��� z���� ���ֱ�
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {   //�Ʒ��ʹ���Ű �Է��� ������ ��� -z���� ���ֱ�
            playerRigidbody.AddForce(0f, 0f,-speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {   //�����ʹ���Ű �Է��� ������ ��� x���� ���ֱ�
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {   //���ʹ���Ű �Է��� ������ ��� -x���� ���ֱ�
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }
}
