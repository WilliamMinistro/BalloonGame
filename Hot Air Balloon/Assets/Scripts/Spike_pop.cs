using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_pop : MonoBehaviour
{

    public Transform balloon;
    public BalloonMovement movement;
    public HealthController die;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            HealthController.Health = HealthController.Health - 100;
            
        }
    }


}
