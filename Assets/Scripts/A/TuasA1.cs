﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuasA1 : MonoBehaviour
{
    public GameObject tuasOpen;

    public static bool DoorAOpen;
    void Start()
    {
        
        DoorAOpen = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            DoorAOpen = !DoorAOpen;
        }
    }
}
