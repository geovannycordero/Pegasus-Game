using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomObjectSpawner : MonoBehaviour
{
    public GameObject arrow;
    public enum EnumObjects
    {
        thunder, arrow
    }
    private float timeBetweenSpawns;
    public float startTimeBetweenSpawns;
    // Time to decrease when there is a level up
    public float decreaseTime;
    public float minTime = 0.65f;
    public Vector2[] initialPositions;
    public int randomPause;
    public int maxPauseTimeArrow;
    public int minPauseTimeArrow;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timeBetweenSpawns -= Time.deltaTime;

        if (timeBetweenSpawns <= 0)
        {
            int randomNumber = Random.Range(0, initialPositions.Length);

            Instantiate(arrow, initialPositions[randomNumber], Quaternion.identity);

            timeBetweenSpawns = Random.Range(minPauseTimeArrow, maxPauseTimeArrow);


        }
        else
        {
            timeBetweenSpawns -= Time.deltaTime;
        }


    }
}
