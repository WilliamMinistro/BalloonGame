using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGenerator : MonoBehaviour
{
    public GameObject spikes;
    public GameObject spikeClone;
    public GameObject SpinningSpikeClone;
    public GameObject FireClone;
    public Text pointText;
    public float respawnTime = 8f;
    private Vector2 bounds;
    public int pointCount;
    public GameObject balloon;
    private int yValue = 6;
    private int yValueRight = 6;
    public int randVariable, randVariableRight;
    bool isSpikeCol;


    System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(objectWave());
    }

    // Update is called once per frame
    void Update()
    {
        bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        if(spikeClone.transform.position.y < bounds.y)
        {
            //Destroy(spikeClone);
        }
        points();
    }

    private void spawnL()
    {
        int whichObj = random.Next(1, 4);

        if (whichObj == 1)
        {
            randVariable = random.Next(6, 10);
  
            yValue = yValue + randVariable;
            Instantiate(spikeClone, new Vector3(-1.95f, (yValue), 0f), Quaternion.Euler(0, 0, -90));
        }

        if (whichObj == 2)
        {
            int randSpikeCol = random.Next(1, 3);

            if (randSpikeCol == 1)
            {
                randVariable = random.Next(7, 9);
                yValue = yValue + randVariable;
                Instantiate(SpinningSpikeClone, new Vector3(-2.45f, (yValue), 0f), Quaternion.Euler(0, 0, -25.445f));
            }
            if (randSpikeCol == 2)
            {
                randVariable = random.Next(8, 9);
                yValue = yValue + randVariable;
                Instantiate(SpinningSpikeClone, new Vector3(-1.75f, (yValue), 0f), Quaternion.Euler(0, 0, 90f));
                isSpikeCol = true;
            }
        }
        if(whichObj == 3)
        {
            randVariable = random.Next(6, 10);
            yValue = yValue + randVariable;
            Instantiate(FireClone, new Vector3(-1.45f, (yValue), 0f), Quaternion.Euler(0, 0, -90));
        }
    }
    private void spawnR()
    {
        int whichObj2 = random.Next(1, 3);

        if (isSpikeCol == false)
        {
            if (whichObj2 == 1)
            {
                randVariableRight = random.Next(6, 10);
                yValueRight = yValueRight + randVariableRight;
                Instantiate(spikeClone, new Vector3(1.95f, (yValueRight), 0f), Quaternion.Euler(0, 0, 90));
            }
            if(whichObj2 == 2)
            {
                randVariableRight = random.Next(6, 10);
                yValueRight = yValueRight + randVariableRight;
                Instantiate(FireClone, new Vector3(1.45f, (yValueRight), 0f), Quaternion.Euler(0, 0, 90));
            }
        }
        else
        {
            randVariableRight = random.Next(7, 10);
            yValueRight = yValueRight + randVariableRight;
        }

        isSpikeCol = false;
        
    }

    IEnumerator objectWave()
    {
        while (true)
        {

            spawnL();
            spawnR();
            yield return new WaitForSeconds(respawnTime);
        }
    }

    public void points()
    {
        Vector3 BalloonY = balloon.transform.position;
        pointCount = (int)BalloonY.y + 3;
        Debug.Log(pointCount);
        pointText.text = "POINTS: " + pointCount;
    }
    
    public void PointChanger()
    {
        
    }
}
