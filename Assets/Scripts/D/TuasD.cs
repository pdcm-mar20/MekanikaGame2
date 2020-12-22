using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuasD : MonoBehaviour
{
    public static bool DoorDOpen;
    void Start()
    {
        DoorDOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DoorDOpen = !DoorDOpen;
        }
    }
}
