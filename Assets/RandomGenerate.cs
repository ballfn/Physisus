using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerate : MonoBehaviour
{
    public int spawnNumber;
    public GameObject spawnItem;
    public GameObject spawnArea;

    void Start()
    {
        GenerateObject();
    }

    public void GenerateObject()
    {
        DestroyObjecy();
        GameObject toSpawn;
        BoxCollider2D coll = spawnArea.GetComponent<BoxCollider2D>();

        float screenX, screenY;
        Vector2 posisition;

        for (int i = 0; i < spawnNumber; i++)
        {
            toSpawn = spawnItem;

            screenX = Random.Range(coll.bounds.min.x, coll.bounds.max.x);
            screenY = Random.Range(coll.bounds.min.y, coll.bounds.max.y);
            posisition = new Vector2(screenX, screenY);

            Instantiate(toSpawn, posisition, toSpawn.transform.rotation);
        }
    }

    private void DestroyObjecy()
    {
        foreach(GameObject item in GameObject.FindGameObjectsWithTag("Spawn"))
        {
            Destroy(item);
        }
    }
}
