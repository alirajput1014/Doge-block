using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float interval = 3f;
    int[] lanepositions = { -8,-4, 0, 4, 8 };
  
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
              int index=Random.Range(0,lanepositions.Length);
            for (int i = 0; i < lanepositions.Length; i++)
            {
                if (i != index)
                {

                    Vector3 spawnPos = new Vector3(lanepositions[i], 14.5f, 1f);
                    GameObject obs =Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
                    Destroy(obs, 3f);
                }
            }
            
            yield return new WaitForSeconds(interval);

        }
        
    }
    
}
