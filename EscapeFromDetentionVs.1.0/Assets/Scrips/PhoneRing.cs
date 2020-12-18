using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneRing : MonoBehaviour
{
    public AudioSource phoneRing;

    void OnTriggerEnter(Collider other)
    {
        phoneRing.Play();
    }
}
