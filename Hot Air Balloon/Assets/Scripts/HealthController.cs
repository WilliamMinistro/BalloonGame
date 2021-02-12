using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public static int Health = 100;
    public AudioSource audioSource;
    [SerializeField] private Animator myAnimationController;
    public GameOver GameOver;
    public static bool happened = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Health <= 0)
        {
            if (happened == false)
            {
                Debug.Log(Health);
                die();
            }
            happened = true;
        }
    }

    public void die()
    {
        myAnimationController.SetBool("Pop", true);
        audioSource.Play();

        GameOver.Setup();
        StartCoroutine(destroyed());
    }

    IEnumerator destroyed()
    {
        yield return new WaitForSeconds(.2f);
        Destroy(this.gameObject);
    }
}
