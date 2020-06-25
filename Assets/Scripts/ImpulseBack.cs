using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseBack : MonoBehaviour
{
    public AudioSource sound;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (sound)
                sound.Play();

            if (other.CompareTag("Player"))
            {
                other.SendMessageUpwards("ImpulseBack");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (sound)
                sound.Play();
            if (other.CompareTag("Player"))
            {
                other.SendMessageUpwards("ImpulseBack");
            }
        }
    }
}

