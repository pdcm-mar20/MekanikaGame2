﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuasH : MonoBehaviour
{
    public static bool DoorHOpen;
    // Start is called before the first frame update
    void Start()
    {
        DoorHOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DoorHOpen = !DoorHOpen;
        }
    }
}
