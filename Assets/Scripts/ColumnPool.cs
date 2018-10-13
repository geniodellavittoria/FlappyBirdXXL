using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

    public int poolsize = 5;
    public GameObject columnprefab;
    public float spawnRate = 4f;
    public float columnMin = -2f;
    public float columnMax = 2f;

    private Vector2 objectPoolPostion = new Vector2(-15f, -25f);
    private GameObject[] columns;
    private float timeSinceLastSpawned;
    private float spawnXpostion = 10f;
    private int currentColumn = 0;

	// Use this for initialization
	void Start () {
        columns = new GameObject[poolsize];
        for (int i =0; i< poolsize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnprefab, objectPoolPostion, Quaternion.identity);
        }		
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastSpawned += Time.deltaTime;

        if(GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYpostion = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXpostion, spawnYpostion);
            currentColumn++;
            if (currentColumn >= poolsize)
            {
                currentColumn = 0;
            }
        }
	}
}
