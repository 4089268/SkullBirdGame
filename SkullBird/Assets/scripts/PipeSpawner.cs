using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 10;
    public float heightOffset = 5;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if( timer < spawnRate)
        {
            timer += Time.deltaTime;
        }else
        {
            SpawnPipe();
            timer = 0;
        }
    }


    private void SpawnPipe()
    {
        float lowestPoint = transform.position.y - this.heightOffset;
        float highestPoint = transform.position.y + this.heightOffset;

        var position = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z);

        Instantiate(this.pipe, position, transform.rotation);
    }
}
