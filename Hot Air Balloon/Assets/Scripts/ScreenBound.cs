using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBound : MonoBehaviour
{
    private Vector2 bounds;
    private float objW;
    private float objH;
    // Start is called before the first frame update
    void Start()
    {

    }

    void LateUpdate()
    {
        
        bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); 
        objH = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        objW = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, -bounds.x + objW - .75f, bounds.x - objW +.75f);
        viewPos.y = Mathf.Clamp(viewPos.y, -bounds.y + objH + .75f, bounds.y - objH +.75f);
        transform.position = viewPos;
    }
}
