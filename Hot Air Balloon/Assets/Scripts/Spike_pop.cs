using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_pop : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] private Animator myAnimationController;
    public Transform balloon;
    public BalloonMovement movement;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            die();
        }
    }

    void die()
    {
        myAnimationController.SetBool("Pop", true);
        audioSource.Play();
    }
}
