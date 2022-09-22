using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody; 
    
    void Start()
    {   
        // 게임 오브젝트에서 Rigidbodty 컴포넌트를 찾아 bulletRigidbody에 할당
        bulletRigidbody = GetComponent<Rigidbody>();
        //리지드바디 속도 = speed* 방향
        bulletRigidbody.velocity = transform.forward * speed;
        //3초 뒤에 자신의 게임 오브젝트 파괴
        Destroy(gameObject, 3f);

    }
    //트리거 충돌시 자동으로 실행되는 메소드
    private void OnTriggerEnter(Collider other)
    {

        // 충돌한 상대방 게임 오브젝트가 Player 태그를 가졌다면
        if(other.tag == "Player")
        {   //상대방 게임 오브젝트에서 PlayerController 컴포넌트 가져오기
            PlayerController playerController = other.GetComponent<PlayerController>();


           //상대방으로부터 PlatyerController 컴포넌트를 가져오는데 성공했다면
           if(playerController!= null)
            {
                //상대방 PlayController 컴포넌트의 Die()에서 메서드 실행
                playerController.Die();
            }
        }
    }

}
