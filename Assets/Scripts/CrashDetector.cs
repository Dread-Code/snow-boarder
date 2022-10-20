using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delay = 0.5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            Invoke("ReloadScene", delay);
        }    
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
