using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// UI���� ���̺귯��
using UnityEngine.SceneManagement;//�� ���� ���� ���̺귯��
using TMPro;//TestMeshPro ���� ���̺귯��


public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;//���ӿ����� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public TextMeshProUGUI timeText;// ���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public TextMeshProUGUI recordText;//�ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime;// �����ð�
    private bool isGameover; // ���ӿ��� ����


    // Start is called before the first frame update
    void Start()
    {
        //���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0;
        isGameover = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameover)
        {
            //�����ð� Ȯ��
            surviveTime += Time.deltaTime;
            //������ ���� �ð��� timeText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            timeText.text = "Time: " + (int)surviveTime;
        }
        else
        {
            //���ӿ��� ���¿��� RŰ�� ���� ���
            if(Input.GetKeyDown(KeyCode.R))
            {
              SceneManager.LoadScene("Main Scenes");
            }
        }

    }
    public void EndGame()
    {
        //���� ���¸� ���� �������·� ��ȯ
        isGameover = true;
        //���� ���� �ؽ�Ʈ ���ӿ�����Ʈ�� Ȱ��ȭ
        gameoverText.SetActive(true);
    }
}
