using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuasK : MonoBehaviour
{
    public static bool DoorKOpen;
    // Start is called before the first frame update
    void Start()
    {
        DoorKOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DoorKOpen = !DoorKOpen;
        }
    }
}
