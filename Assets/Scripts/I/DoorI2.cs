﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorI2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TuasI.DoorIOpen)
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(6.73f, transform.localPosition.y), Time.deltaTime * 2f);
        }
        else
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(8.82f, transform.localPosition.y), Time.deltaTime * 2f);
        }
    }
}
