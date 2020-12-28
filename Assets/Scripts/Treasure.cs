using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    public GameObject Complete;
    public GameObject conditionPanel;
    // Start is called before the first frame update
    void Start()
    {
        Complete.SetActive(false);
        conditionPanel.SetActive(false);
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
            conditionPanel.SetActive(true);
            Time.timeScale = 0f;
            Destroy(gameObject);
        }
    }
}
