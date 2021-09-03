using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongDurationScript : MonoBehaviour
{

    public GameObject songDuration;
    public GameObject elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        int numOfSecs =(int) this.GetComponent<AudioSource>().clip.length;
        int mins = numOfSecs / 60;
        int secs = numOfSecs % 60;
        if (secs < 10)
        {
            songDuration.GetComponent<Text>().text = "" + mins + ":0" + secs;
        }
        else
        {
            songDuration.GetComponent<Text>().text = "" + mins + ":" + secs;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int timePassed =(int) this.GetComponent<AudioSource>().time;
        int mins = timePassed / 60;
        int secs = timePassed % 60;
        if (secs < 10)
        {
            elapsedTime.GetComponent<Text>().text = "" + mins + ":0" + secs;
        }
        else
        {
            elapsedTime.GetComponent<Text>().text = "" + mins + ":" + secs;
        }
    }

}
