using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Video;
public class PlaybackProgressScript : MonoBehaviour
{

    public Slider audioSlider;
    public float percentage;
    bool beingClicked = false;
    float finalPercent = 0.0f;
    public GameObject mainCamera;

    // Use this for initialization
    void Start()
    {
        audioSlider.direction = Slider.Direction.LeftToRight;
        audioSlider.minValue = 0;
        audioSlider.maxValue = this.GetComponent<AudioSource>().clip.length;
        mainCamera.GetComponent<VideoPlayer>().SetDirectAudioMute(0,true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.GetComponent<AudioSource>().time==this.GetComponent<AudioSource>().clip.length)
        {
            finalPercent = 0.0f;
            this.GetComponent<AudioSource>().time = 0.0f;
            mainCamera.GetComponent<VideoPlayer>().time = 0.0f;
            audioSlider.value = 0.0f;
            if(mainCamera.GetComponent<VideoPlayer>().isLooping == false)
            {
                mainCamera.GetComponent<VideoPlayer>().Pause();
            }
            

        }
        

        if (Input.GetMouseButton(0))
        {
            //Debug.Log(percentage);
            beingClicked = true;
            finalPercent = percentage;
            if (SliderColliderScript.clicked == false)
            {
                finalPercent = -1.0f;
            }
            
            
            
        }
        else if(!Input.GetMouseButton(0))
        {
            if (beingClicked == true)
            {
                if (finalPercent >= 0.0f)
                {
                    this.GetComponent<AudioSource>().time = (int)(this.GetComponent<AudioSource>().clip.length * finalPercent);
                    mainCamera.GetComponent<VideoPlayer>().time = (int)(mainCamera.GetComponent<VideoPlayer>().clip.length * finalPercent);
                    beingClicked = false;
                }
            }
        }
        if (beingClicked == false)
        {
            audioSlider.value = this.GetComponent<AudioSource>().time;

            //this.GetComponent<AudioSource>().Play();
        }
    }

    public void ManualControl(float percent)
    {
        percentage = percent/ this.GetComponent<AudioSource>().clip.length;
        
    }

    public void LoopClicked()
    {
        if (this.GetComponent<AudioSource>().loop != true)
        {
            this.GetComponent<AudioSource>().loop = true;
            mainCamera.GetComponent<VideoPlayer>().isLooping = true;
        }
        else
        {
            this.GetComponent<AudioSource>().loop = false;
            mainCamera.GetComponent<VideoPlayer>().isLooping = false;
        }
    }
}