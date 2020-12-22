using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorH1 : MonoBehaviour
{
    void Update()
    {
        if (TuasH.DoorHOpen)
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(transform.localPosition.x, -2.85f), Time.deltaTime * 2f);
        }
        else
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(transform.localPosition.x, -6.39f), Time.deltaTime * 2f);
    }
}
}
