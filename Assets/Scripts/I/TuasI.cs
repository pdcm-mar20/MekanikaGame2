using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuasI : MonoBehaviour
{
    public static bool DoorIOpen;
    // Start is called before the first frame update
    void Start()
    {
        DoorIOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DoorIOpen = !DoorIOpen;
        }
    }
}
