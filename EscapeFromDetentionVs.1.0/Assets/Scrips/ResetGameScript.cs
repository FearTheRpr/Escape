using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGameScript : MonoBehaviour
{
    public GameObject scene;

     public void resetGame()
    {
       //resets the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
