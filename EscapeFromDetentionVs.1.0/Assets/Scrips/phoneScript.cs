using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phoneScript : MonoBehaviour
{
    public AudioSource phoneCall;
    public GameObject sourceOfCall;
    public GameObject triggerBox;
    public GameObject sourceOfRinging;

    public void answerThePhone()
    {
        triggerBox.SetActive(false);
        sourceOfRinging.SetActive(false);
        phoneCall.Play();

    }

    public void hangUp()
    {
        sourceOfRinging.SetActive(false);
    }
}
