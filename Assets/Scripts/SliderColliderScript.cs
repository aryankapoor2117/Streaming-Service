using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderColliderScript : MonoBehaviour
{
    public static bool clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            Debug.Log(Input.mousePosition.x);
            if (Input.mousePosition.x>= 375.0f && Input.mousePosition.x<= 535.0f && Input.mousePosition.y<= 69.0f && Input.mousePosition.y>=52.0f)
            {
               
                    clicked = true;
                
            }
            else
            {
                clicked = false;
            }
        }
        else
        {
            clicked = false;
        }
    }
}
