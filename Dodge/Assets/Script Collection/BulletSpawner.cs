using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;// 생성할 탄알의 원본 프리팹
    public float spawnRateMin = 0.5f;// 최소 생성주기
    public float spawnRateMax = 3f; // 최대 생성주기

    private Transform target; // 발사할대상
    private float spawnRate; // 생성주기
    private float timeAfterSpawn;// 최근 생성 시점에서 지난 시간

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
