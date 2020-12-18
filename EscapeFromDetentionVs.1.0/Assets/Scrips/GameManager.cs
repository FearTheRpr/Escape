using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //array that holds all the random places for the book to spawn
    public List<GameObject> RandomEmptys = new List<GameObject>();
    public GameObject BookPrefab;
    public static int Score = 0;
    public GameObject WinScreen;
    public GameObject thirdButton;
    public AudioSource winner;
    public AudioSource almostDone;

    // Use this for initialization
    void Start()
    {
        //spawns in a key at a random place 
        int chosenSpawnPoint = Random.Range(0, RandomEmptys.Count);
        GameObject instantiatedKey = GameObject.Instantiate(BookPrefab,RandomEmptys[chosenSpawnPoint].transform.position, Quaternion.identity, transform);
        
    }



    // Check the score to see what to do next
    void Update()
    {
        if (Score == 2)
        {
            thirdButton.SetActive(true);
            almostDone.Play();

        }
        if (Score == 3)
        {
            Debug.Log("You Win");
            WinScreen.SetActive(true);
            winner.Play();
            Score = 0;

        }
        else
        {

        }
    }


}
