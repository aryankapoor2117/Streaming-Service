using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAway : MonoBehaviour
{
    bool moveAwayBool = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (moveAwayBool == true)
        {
            Vector2 target = new Vector2(this.transform.position.x, -410.0f);
            this.transform.position = Vector2.MoveTowards(this.transform.position, target, 5.0f);
        }
    }

    public void MoveAwayStart()
    {
        moveAwayBool = true;
    }
}
