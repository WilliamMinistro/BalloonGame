using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class scroll_script : MonoBehaviour
{
    public GameObject balloon;
    public static float speed = .05f;
    public int pointCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpeedUp());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed, 0);
    }

    IEnumerator SpeedUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(44);
            speed = speed * 1.3f;
            BalloonMovement.speed = BalloonMovement.speed * 1.3f;

        }
    }
}
