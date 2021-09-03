 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{

    bool clicked = false;
    string songName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                //Debug.Log(hit.collider.gameObject.name);
                clicked = true;
                string playName = hit.collider.gameObject.name;

                songName = "Song " + playName.Substring(playName.Length - 1);
                //  hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
        }

        if(clicked==true)
        {
            //move the song to 0,0
            GameObject temp = GameObject.Find(songName);
            Vector2 target =new Vector2(456.0f, 256.5f);
            temp.transform.position= Vector2.MoveTowards(temp.transform.position, target, 1.2f);
            string tempName = "";
            for(int i =1;i<=7;i++)
            {
                tempName = "Song " + i.ToString();
                if(tempName.Equals(songName))
                {
                    tempName = "";
                    continue;
                }
                else
                {
                    GameObject otherSong = GameObject.Find(tempName);
                    otherSong.GetComponent<MoveAway>().MoveAwayStart();
                }
            }

            Vector3 targetReached = new Vector3(456.0f, 256.5f, 390.6627f);
            if(temp.transform.position.x==456.0f|| temp.transform.position.x == 256.5f)
            {

               // SceneChanger obj = new SceneChanger();
                SceneChanger.ChangeScene(temp.gameObject.name);
            }
            // Debug.Log(temp.gameObject.name);
        }
    }

    //private void OnColliderEnter2D(Collider2D collision)
    //{
    //    if(Input.GetMouseButtonDown(0))
    //    {
    //        Debug.Log("Button Clicked");
    //    }
    //}

    
}
