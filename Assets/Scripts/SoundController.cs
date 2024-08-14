using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioClip dieSFX;
    [SerializeField] AudioClip pointSFX;
    [SerializeField] AudioClip hitSFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            GetComponent<AudioSource>().PlayOneShot(hitSFX);
            GetComponent<AudioSource>().PlayOneShot(dieSFX);
        } else if (other.gameObject.CompareTag("Scoring")) {
            GetComponent<AudioSource>().PlayOneShot(pointSFX);
        }
    }
}
