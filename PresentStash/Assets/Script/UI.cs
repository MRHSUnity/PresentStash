using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public AudioClip collectedClip;
    public ParticleSystem particle;
    void OnTriggerEnter2D(Collider2D other)
    {
        playerControl controller = other.GetComponent<playerControl>();
        if (controller != null)
        {
            if (controller.health < controller.presentN)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
                particle.Stop();
            }
        }
    }
}