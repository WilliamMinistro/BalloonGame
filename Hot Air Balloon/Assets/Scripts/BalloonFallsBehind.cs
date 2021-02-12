using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonFallsBehind : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        HealthController.Health = 0;
        Debug.Log(1);
    }
}
