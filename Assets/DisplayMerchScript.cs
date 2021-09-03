using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMerchScript : MonoBehaviour
{

    public GameObject SongPlayer;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Image>().enabled = false;
        this.GetComponentInChildren<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(SongPlayer.GetComponent<AudioSource>().time >= SongPlayer.GetComponent<AudioSource>().clip.length/4)
        {
            this.gameObject.GetComponent<Image>().enabled = true;
            this.GetComponentInChildren<Text>().enabled = true;

        }
        if(SongPlayer.GetComponent<AudioSource>().time >= SongPlayer.GetComponent<AudioSource>().clip.length / 2)
        {
            this.gameObject.GetComponent<Image>().enabled = false;
            this.GetComponentInChildren<Text>().enabled = false;
        }
    }
}
