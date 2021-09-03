using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLyricBackground : MonoBehaviour
{
    public GameObject panel;
    public Vector3 defaultPosition;

    public void Start()
    {
        var temp = GameObject.Find("LyricPanel").transform.GetComponent<RectTransform>();
        defaultPosition = temp.localPosition;
        var sayDialog = GameObject.Find("LyricPanel").transform.GetComponent<RectTransform>();
        //panel.transform.GetComponent<Text>().enabled = true;
        var pos = sayDialog.localPosition;
        sayDialog.localPosition = new Vector3(pos.x, 840, pos.z);
        this.gameObject.GetComponent<Image>().enabled = false;
    }

    public void BackgroundOn()
    {
        Debug.Log("Clicking");
        if (this.gameObject.GetComponent<Image>().enabled == true)
        {
            this.gameObject.GetComponent<Image>().enabled = false;
           //panel= GameObject.Find("LyricPanel");
           // panel.GetComponent<RectTransform>().position.z = -100000;
            var sayDialog = GameObject.Find("LyricPanel").transform.GetComponent<RectTransform>();
            //panel.transform.GetComponent<Text>().enabled = true;
            var pos = sayDialog.localPosition;
            sayDialog.localPosition = new Vector3(pos.x, 840, pos.z);
            // panel.SetActive(true);
            //panel.GetComponent<MeshRenderer>().enabled = true;

        }
        else
        {
            //panel = GameObject.Find("LyricPanel");
            //panel.transform.GetComponent<Text>().enabled = false;
            this.gameObject.GetComponent<Image>().enabled = true;
            //panel = GameObject.Find("LyricPanel");
            //panel.SetActive(false);
            var sayDialog = GameObject.Find("LyricPanel").transform.GetComponent<RectTransform>();
            var pos = sayDialog.localPosition;
            sayDialog.localPosition = new Vector3(defaultPosition.x,defaultPosition.y,defaultPosition.z);
            // panel.GetComponent<MeshRenderer>().enabled = false;
        }

    }
}
