using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPlayer : MonoBehaviour
{
    private static GameObject instance;

    public void DestroyPlayer()
    {
        Destroy(gameObject);
    }
}
