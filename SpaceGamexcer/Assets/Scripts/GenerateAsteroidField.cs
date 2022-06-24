using System.Collections;
using System.Collections.Generic;
using GDTools.ObjectPooling;
using UnityEngine;

public class GenerateAsteroidField : MonoBehaviour
{
    public Transform asteroidPrefab;
    public int fieldRadius = 100;
    public int asteroidCount = 100;
    //public List<Transform> asteroidList = new List<Transform>();
 

    // Start is called before the first frame update
    
    void Start()
    {
        //asteroidList = new List<Transform>();
        // asteroidList.Add(asteroidPrefab1);
        // asteroidList.Add(asteroidPrefab2);
        
        //for(int i = 0; i < asteroidList.Count; i++)
        for (int loop = 0; loop < asteroidCount; loop++)
        {
            Transform temp = Instantiate(asteroidPrefab, Random.insideUnitSphere * fieldRadius, Random.rotation);
            //Transform temp =  Instantiate(asteroidList[i], Random.insideUnitSphere * fieldRadius, Random.rotation);

            temp.localScale = temp.localScale * Random.Range(0.5f, 5);
            temp.transform.parent = gameObject.transform; //asteroid prefabs created in child of field center

        }    
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    
  
}
