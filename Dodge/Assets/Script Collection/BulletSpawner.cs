using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;// ������ ź���� ���� ������
    public float spawnRateMin = 0.5f;// �ּ� �����ֱ�
    public float spawnRateMax = 3f; // �ִ� �����ֱ�

    private Transform target; // �߻��Ҵ��
    private float spawnRate; // �����ֱ�
    private float timeAfterSpawn;// �ֱ� ���� �������� ���� �ð�

    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
