using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPauseSpriteSwap : MonoBehaviour
{

    public Sprite playSprite;
    public Sprite pauseSprite;
    public void PlayPause()
    {
        Button button = this.GetComponent<Button>();
        GameObject obj = GameObject.Find("SongPlayer");
        AudioSource temp = obj.GetComponent<AudioSource>();
        if (temp.isPlaying == true)
        {
            //temp.Pause();
            this.GetComponent<Image>().sprite = pauseSprite;
            
        }
        else
        {
            //temp.Play();
            this.GetComponent<Image>().sprite = playSprite;
            
        }
    }
}
