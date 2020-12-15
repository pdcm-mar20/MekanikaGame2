using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorF1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TuasF.DoorFOpen)
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(transform.localPosition.x, 1.5f), Time.deltaTime * 2f);
        }
        else
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(transform.localPosition.x, -3.5f), Time.deltaTime * 2f);
        }
    }
}
