using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSound : MonoBehaviour
{
    public AudioSource src;
    public AudioClip ballSound;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    private void onCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("cube"))
        {
            src.clip = ballSound;
            src.Play();
        }
            
        
    }
}