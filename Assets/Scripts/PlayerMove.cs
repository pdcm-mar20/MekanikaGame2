using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerMove : MonoBehaviour
{
    Rigidbody2D Rb;
    public float speed;
    public float jump;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        print(horiz);

        transform.Translate(new Vector2(speed * horiz * Time.deltaTime,0));
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            Rb.velocity = Vector2.up * jump;
        }
    }
}
