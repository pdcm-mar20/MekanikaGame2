using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorD1 : MonoBehaviour
{
    float posX;
    void Start()
    {
        posX = transform.localPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (TuasD.DoorDOpen)
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(posX+2, transform.localPosition.y), Time.deltaTime * 2f);
        }
        else
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(posX, transform.localPosition.y), Time.deltaTime * 2f);
        }
    }
}
