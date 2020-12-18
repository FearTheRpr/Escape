using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerAnimationScript : MonoBehaviour
{
    public Animator animator;
    public AudioSource lockerSound;

    // Start is called before the first frame update


    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Text());

        IEnumerator Text()
        {

            animator.SetBool("Open", true);
            Debug.Log("Open Door");
            yield return new WaitForSeconds(0.5f);
            animator.SetBool("Open", false);
            lockerSound.Play();
        }
    }



}
