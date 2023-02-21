using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrails : MonoBehaviour
{
        [SerializeField] ParticleSystem boardEffect;
    void Update()
    {
        
    }
     void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            boardEffect.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Ground")
        {
            boardEffect.Stop();
        }           
    }
}
