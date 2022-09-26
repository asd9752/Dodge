using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBulletSpawner : MonoBehaviour
{
    public GameObject CubeBulletPrefab;
    public float spawnratemin = 0.5f;
    public float spawnratemax = 3f;

    private Transform target;
    private float spawnrate;
    private float timeafterspawn;


    // Start is called before the first frame update
    void Start()
    {
        timeafterspawn = 0f;
        spawnrate = Random.Range(spawnratemin, spawnratemax);
        target = FindObjectOfType<PlayerController4>().transform;


    }

    // Update is called once per frame
    void Update()
    {
        timeafterspawn += Time.deltaTime;
        if (timeafterspawn >= spawnrate)
        {
            GameObject cubebullet
                = Instantiate(CubeBulletPrefab, transform.position, transform.rotation);


            cubebullet.transform.LookAt(target);

            spawnrate = Random.Range(spawnratemin, spawnratemax);

        }


    }
}
