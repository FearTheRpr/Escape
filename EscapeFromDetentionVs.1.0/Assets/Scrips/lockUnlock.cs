using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lockUnlock : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource keySound;

  void OnCollisionEnter(Collision other)
  {
        if (other.collider.tag == "secretKeys")
        {

            //plays sound to show items being destroyed
            keySound.Play();

            //adds 1 to the score whenever a key is used
            GameManager.Score += 1;

            //destroys lock and key to show player how many keys they have left to find and prevent them from using a key twice
            Destroy(other.gameObject);
            Destroy(gameObject);

            
        }

  }
}
