using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController4 : MonoBehaviour
{
    private Rigidbody CubeRigdibody;
    public float speed = 38f;


    // Start is called before the first frame update
    void Start()
    {
        CubeRigdibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {   //���ʹ���Ű �Է��� ������ ��� z���� ���ֱ�
            CubeRigdibody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {   //�Ʒ��ʹ���Ű �Է��� ������ ��� -z���� ���ֱ�
            CubeRigdibody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {   //�����ʹ���Ű �Է��� ������ ��� x���� ���ֱ�
            CubeRigdibody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {   //���ʹ���Ű �Է��� ������ ��� -x���� ���ֱ�
            CubeRigdibody.AddForce(-speed, 0f, 0f);
        }
    }

    public void Die()
    {

        gameObject.SetActive(false);
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
