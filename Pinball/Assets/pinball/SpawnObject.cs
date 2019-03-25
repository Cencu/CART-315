using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Vector3 center;
    public Vector3 size;
    public GameObject AsteroidPrefab;
    private int TheNumber;
    private int NumDown = 5000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TheNumber = Random.Range(1, NumDown);
        if (TheNumber <= 3)
        {
            SpawnAsteroids();
            NumDown += 100;
        }
        NumDown--;
        //Debug.Log(TheNumber);
    }

    public void SpawnAsteroids()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2, size.x /2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(AsteroidPrefab, pos, Quaternion.identity);

    }
    //when you select this game object, it will draw what you put in this function
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 1);
        Gizmos.DrawCube(center, size);
    }
}
