using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using GDTools.ObjectPooling;

using UnityEngine;
using UnityEngine.EventSystems;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private Pool pool; //pool reference
    [SerializeField] private float spawnDelay;
    public Vector3 moveDirection;
    public Transform Position;
    public float speed = 3f;

    private WaitForSeconds delay;

    void Start()
    {
        delay = new WaitForSeconds(spawnDelay);
        StartCoroutine(RandomSpawning());

    }

    // void Update()
    // {
    //     moveDirection = (transform.right)*speed;
    // }

    private IEnumerator RandomSpawning()
    {
        while (true)
        {
            yield return delay;

            
                // PoolObject asteroid = Spawn();
                // transform.Translate(moveDirection, Space.World);
                //Instanciate asteroid
                Asteroid asteroid = (Asteroid)Spawn();
                asteroid.rb.velocity = Vector3.left * 15f * Time.deltaTime;
                // asteroid.rb.velocity = new Vector3(moveDirection.x, 0f, 0f); 
                // asteroid.rb.velocity = new Vector3(speed, 0, 0);
                pool.DestroyObject(asteroid, 3f);
        
            
        }
    }

    private PoolObject Spawn()
    {
        return pool.InstantiateObject(
            new Vector3(Random.Range(-1.0f, 1.0f), 7.0f,-14.0f),
            Quaternion.identity
            );
    }
}
