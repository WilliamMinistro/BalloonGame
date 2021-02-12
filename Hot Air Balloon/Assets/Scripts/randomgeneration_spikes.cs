using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomgeneration_spikes : MonoBehaviour
{
    public GameObject SpikesFINAL;
    private int orientation;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(SpikesFINAL, new Vector3(-2.43f, -1.43f, -3.43f), Quaternion.Euler(0, 0, -90));
    }

    // Update is called once per frame
    void Update() { }
}