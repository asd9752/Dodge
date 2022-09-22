using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody; 
    
    void Start()
    {   
        // ���� ������Ʈ���� Rigidbodty ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ� �ӵ� = speed* ����
        bulletRigidbody.velocity = transform.forward * speed;
        //3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);

    }
    //Ʈ���� �浹�� �ڵ����� ����Ǵ� �޼ҵ�
    private void OnTriggerEnter(Collider other)
    {

        // �浹�� ���� ���� ������Ʈ�� Player �±׸� �����ٸ�
        if(other.tag == "Player")
        {   //���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();


           //�������κ��� PlatyerController ������Ʈ�� �������µ� �����ߴٸ�
           if(playerController!= null)
            {
                //���� PlayController ������Ʈ�� Die()���� �޼��� ����
                playerController.Die();
            }
        }
    }

}
