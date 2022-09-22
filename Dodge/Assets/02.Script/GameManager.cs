using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// UI관련 라이브러리
using UnityEngine.SceneManagement;//씬 관리 관련 라이브러리
using TMPro;//TestMeshPro 관련 라이브러리


public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;//게임오버시 활성화할 텍스트 게임 오브젝트
    public Text timeText;// 생존 시간ㅇ을 표시할 텍스트 컴포넌트
    public Text recordText;//최고 기록을 표시할 텍스트 컴포넌트

    private float surviveTime;// 생존시간
    private bool isGameover; // 게임오버 상태


    // Start is called before the first frame update
    void Start()
    {
        //생존 시간과 게임오버 상태 초기화
        surviveTime = 0;
        isGameover = false;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void EndGame()
    {

    }
}
