using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorE1 : MonoBehaviour
{
    float posX;
    void Start()
    {
        posX = transform.localPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (TuasE.DoorEOpen)
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(posX + 5, transform.localPosition.y), Time.deltaTime * 2f);
        }
        else
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(posX, transform.localPosition.y), Time.deltaTime * 2f);
        }
    }
}
