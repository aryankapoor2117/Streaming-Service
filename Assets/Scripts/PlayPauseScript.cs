using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayPauseScript : MonoBehaviour
{

    public Sprite playSprite;
    public Sprite pauseSprite;

    public GameObject mainCamera;

    public void PlayPause()
    {


        AudioSource temp = this.GetComponent<AudioSource>();
        if(temp.isPlaying==true)
        {
            temp.Pause();
            mainCamera.GetComponent<VideoPlayer>().Pause();


        }
        else
        {
            temp.Play();
            mainCamera.GetComponent<VideoPlayer>().Play();

        }
    }
}
