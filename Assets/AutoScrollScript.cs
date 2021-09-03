using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoScrollScript : MonoBehaviour
{
    // Start is called before the first frame update

    public ScrollRect scrollR;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = new Vector2(0f, Mathf.Sin(Time.time * 10f) * 100f);
        scrollR.content.localPosition = scrollR.normalizedPosition;
    }
}
