using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlaySound : MonoBehaviour

{
    public AudioSource WinSound;
    public AudioSource coinPickUp;

    public void WinSoundPlay()
    {
        WinSound.Play();
    }
    public void CoinPickUpPlay()
    {
        coinPickUp.Play();
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
