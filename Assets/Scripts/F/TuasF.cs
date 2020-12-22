using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuasF : MonoBehaviour
{
    public static bool DoorFOpen;
    void Start()
    {
        DoorFOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DoorFOpen = !DoorFOpen;
        }
    }
}
