using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCRKey : MonoBehaviour
{

    public GameObject VKey;
    public AudioSource eject;

    public void ejectTheKey()
    {
        //Makes the key in front of the VCR appear
        VKey.SetActive(true);
        eject.Play();
    }
}
