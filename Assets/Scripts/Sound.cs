using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {
    private AudioSource audioSource;

    void Start() {
        GetComponent<AudioSource>().playOnAwake = false;
        audioSource = GetComponent<AudioSource>(); 
    }
    void OnMouseDown() {
            audioSource.Play();
    }
}
