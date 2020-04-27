using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    private AudioSource song;
    public AudioClip spawning;

    
    // Start is called before the first frame update
    void Start()
    {
        song = GetComponent<AudioSource>();
        if (song && spawning)
        {
            song.clip = spawning;
            song.Play();
        }
        
    }

    // Update is called once per frame
   
    public void changeVolume(float newVolumen)
    {
        song.volume = newVolumen;   
    }
}

