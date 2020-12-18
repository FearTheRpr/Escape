using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teachersDesk : MonoBehaviour
{
    
    public AudioSource keySound;
    public GameObject drawerOne;
    public GameObject drawertwo;

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "TeachersKey")
        {

            //switches prefabs from drawer one to drawer 2
            drawerOne.SetActive(false);
            drawertwo.SetActive(true);

            //plays sound to show items being destroyed
            keySound.Play();

            

            //destroys key
            Destroy(other.gameObject);
            

            
        }

    }
}
