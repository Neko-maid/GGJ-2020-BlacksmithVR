using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{

AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying) {
            source.pitch=Random.Range(0.8f,1.2f);
            source.Play();
            
        }
        
    }
}
