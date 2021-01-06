using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNER : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Bird1;
    public GameObject Bird2;
    public GameObject Bird3;
    public GameObject Bird4;
    public GameObject Bird5;
    //public float TimeSpawn;

   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(Random.Range(1f, 10f));
        int randomNumber = Random.Range(0, 4);
 
        switch(randomNumber)
        {
            case 0: Instantiate(Bird1 ,SpawnPos.position, Quaternion.identity); break;
 
            case 1: Instantiate(Bird2 ,SpawnPos.position, Quaternion.identity); break;
 
            case 2: Instantiate(Bird3 ,SpawnPos.position, Quaternion.identity); break;

            case 3: Instantiate(Bird4 ,SpawnPos.position, Quaternion.identity); break;

            case 4: Instantiate(Bird5 ,SpawnPos.position, Quaternion.identity); break;
 
        }
        //Instantiate(Cube,SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
