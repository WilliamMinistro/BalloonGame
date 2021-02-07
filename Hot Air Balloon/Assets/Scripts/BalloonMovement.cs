using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    private Touch theTouch;
    public Transform balloonMovement;
    float speed = .01f;
    public float smooth = 1f;
    private Quaternion targetRotation;
    // Start is called before the first frame update

    void Start()
    {
        Invoke("Update", 20);
        targetRotation = transform.rotation;
    }

    // Update is called once per frame

    void Update()
    {
        Debug.Log(balloonMovement.rotation.z);
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(theTouch.position);

            if (theTouch.phase == TouchPhase.Moved)
            {
                    if (touchPos.x <= balloonMovement.position.x)
                    {
                        transform.Translate(-speed, speed, 0);
                        targetRotation *= Quaternion.AngleAxis(-20, Vector3.back);
                    }
                    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
                    if (touchPos.x >= balloonMovement.position.x)
                    {
                        transform.Translate(speed, speed, 0);
                        targetRotation *= Quaternion.AngleAxis(20, Vector3.back);
                    }
                    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
            }
        }
    }
}
