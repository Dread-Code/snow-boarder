using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", delay);
        }    
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
