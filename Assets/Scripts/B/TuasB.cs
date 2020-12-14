using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuasB : MonoBehaviour
{
    public GameObject tuasOpen;

    public static bool DoorBOpen;
    void Start()
    {
        DoorBOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DoorBOpen = !DoorBOpen;
        }
    }
}
