using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggle : MonoBehaviour
{
    AudioSource audioSource;
    bool playing;
    // Start is called before the first frame update
    void Start()
    {
       audioSource = GetComponent<AudioSource>();
       audioSource.Play();
       playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1") && playing == true) {
            audioSource.Pause();
            playing = false;
        } else if (Input.GetKeyDown("1") && playing == false) {
            audioSource.Play();
            playing = true;
        }
    
    }
}