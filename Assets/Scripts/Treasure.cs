using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    public GameObject Complete;
    // Start is called before the first frame update
    void Start()
    {
        Complete.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            TreasureText.treasure += 1;
            Complete.SetActive(true);
            Destroy(gameObject);
        }
    }
}
