using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D Rb;
    public float ms;
    public float jf;
    
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = CrossPlatformInputManager.GetAxis("Horizontal") * 10f;
        print(horiz);
        Rb.velocity = new Vector2(ms * horiz, Rb.velocity.y);
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            Rb.velocity = Vector2.up * jf;
        }
    }
}
