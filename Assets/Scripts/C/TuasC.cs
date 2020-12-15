using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuasC : MonoBehaviour
{
    public static bool DoorCOpen;
    void Start()
    {
        DoorCOpen = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DoorCOpen = !DoorCOpen;
        }
    }
}
