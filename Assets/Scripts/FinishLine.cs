using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay = 1f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Invoke("ReloadScene", delay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
