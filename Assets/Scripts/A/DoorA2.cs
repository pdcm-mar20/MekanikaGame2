using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorA2 : MonoBehaviour
{
    void Update()
    {
        if (TuasA1.DoorAOpen)
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(transform.localPosition.x, -0.5f), Time.deltaTime * 2f);
        }
        else
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(transform.localPosition.x, 7.6f), Time.deltaTime * 2f);
        }
    }
}
