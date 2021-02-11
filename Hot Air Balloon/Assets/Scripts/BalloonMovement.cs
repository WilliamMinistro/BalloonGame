using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    private Touch theTouch, theTouchAfter;
    public Transform balloonMovement;
    float speed = 2f;
    public float smooth = 1f;
    private Quaternion targetRotation;
    bool fingerOff = false;
    public float angle = 391.1f;
    // Start is called before the first frame update

    Vector2 VectorFromAngle(float T)
    {
        return new Vector2(Mathf.Cos(T), Mathf.Sin(T));
    }

    void Start()
    {
        Invoke("Update", 20);
        targetRotation = transform.rotation;
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.touchCount > 0 )
        {
            theTouch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(theTouch.position);

            if (theTouch.phase == TouchPhase.Moved)
            {
                    if (touchPos.x <= balloonMovement.position.x)
                    {
                       
                        targetRotation *= Quaternion.AngleAxis(-20, Vector3.back);
                    }
                    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
                    if (touchPos.x >= balloonMovement.position.x)
                    {
                        targetRotation *= Quaternion.AngleAxis(20, Vector3.back);
                    }
                    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
            }
            if (theTouch.phase == TouchPhase.Ended)
            {
                fingerOff = true;

            }
        }

        
        if (fingerOff == true)
        {

            transform.Translate(VectorFromAngle(angle) * speed * Time.deltaTime);
            if (Input.touchCount > 0)
            {
                theTouchAfter = Input.GetTouch(0);
                if (theTouchAfter.phase == TouchPhase.Began)
                {
                    fingerOff = false;
                }
            }
        }
    }
}
