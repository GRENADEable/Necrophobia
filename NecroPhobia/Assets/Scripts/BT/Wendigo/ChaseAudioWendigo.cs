﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseAudioWendigo : MonoBehaviour
{
    public AudioClip growlClip;
    public AudioClip chaseClip;

    private AudioSource aud;

    void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider play)
    {
        if (play.gameObject.tag == "Player")
        {
            aud.PlayOneShot(growlClip, 0.15f);
            aud.PlayOneShot(chaseClip, 0.15f);
        }

    }
    private void OnTriggerExit(Collider stop)
    {
        if (stop.gameObject.tag == "Player")
        {
            aud.Stop();
        }
    }
}
