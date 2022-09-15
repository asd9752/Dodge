using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private Rigidbody playerRigidbody;
   public float speed = 8f;

    void Start()
    {
        GetComponent<Rigidbody>();
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per framE
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {   //���ʹ���Ű �Է��� ������ ��� z���� ���ֱ�
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {   //�Ʒ��ʹ���Ű �Է��� ������ ��� -z���� ���ֱ�
            playerRigidbody.AddForce(0f, 0f, -speed);
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
    public void die()
    {
        gameObject.SetActive(false);
    }
}
