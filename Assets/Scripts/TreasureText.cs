using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureText : MonoBehaviour
{
    Text treasureText;
    public static int treasure;
    // Start is called before the first frame update
    void Start()
    {
        treasure = 0;
        treasureText = GetComponent<Text>();  
    }

    // Update is called once per frame
    void Update()
    {
        treasureText.text = "Treasure : " + treasure.ToString();
    }
}
