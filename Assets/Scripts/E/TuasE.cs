using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuasE : MonoBehaviour
{
    public static bool DoorEOpen;
    void Start()
    {
        DoorEOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DoorEOpen = !DoorEOpen;
        }
    }
}
