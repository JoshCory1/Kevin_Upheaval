using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem deathEffect;
    [SerializeField] AudioClip boomSFX;
    [SerializeField] float timeTillDeath = 0.5f;
    bool isCrashing = false;
   private void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == "Ground" && !isCrashing)
        {
            isCrashing = true;
            Crash();
        }
    }

    private void Crash()
    {
        FindObjectOfType<PlayerController>().DisableContorls();
        deathEffect.Play();
        GetComponent<AudioSource>().PlayOneShot(boomSFX);
        Invoke("loadScene", timeTillDeath);
    }

    void loadScene()
    {
        SceneManager.LoadScene(0);
    }
}
