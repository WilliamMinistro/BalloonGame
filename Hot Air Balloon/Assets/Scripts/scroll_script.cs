using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_script : MonoBehaviour
{
    public float speed = .003f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed, 0);
    }
}
