using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinshLine : MonoBehaviour
{
    [SerializeField] ParticleSystem winEffect;
    [SerializeField] float timeTillWin = 0.5f;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            winEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("loadScene", timeTillWin);
        }
    }

    void loadScene()
    {
        SceneManager.LoadScene(0);
    }
}
