using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    private Touch theTouch;
    public Transform balloonMovement;
    float speed = .01f;
    float yMax = -1f;
    // Start is called before the first frame update

    void Start()
    {
        Invoke("Update", 20);
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(theTouch.position);
            if (balloonMovement.position.y < yMax)
            {
                if (theTouch.phase == TouchPhase.Began)
                {
                    transform.Translate(0, speed, 0);
                }
            }
            if (theTouch.phase == TouchPhase.Moved)
            {
                if (balloonMovement.position.y < yMax)
                {
                    transform.Translate(0, speed, 0);
                }
                if (balloonMovement.position.y < yMax)
                { 
                    if (touchPos.x <= balloonMovement.position.x)
                    {
                        transform.Translate(-speed, speed, 0);
                    }
                    if (touchPos.x >= balloonMovement.position.x)
                    {
                        transform.Translate(speed, speed, 0);
                    }
                }
                if (balloonMovement.position.y >= yMax)
                {
                    if (touchPos.x <= balloonMovement.position.x)
                    {
                        transform.Translate(-speed, 0, 0);
                    }
                    if (touchPos.x >= balloonMovement.position.x)
                    {
                        transform.Translate(speed, 0, 0);
                    }
                }
            }
        }
    }
}
