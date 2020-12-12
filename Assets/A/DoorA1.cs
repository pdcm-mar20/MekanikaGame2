using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorA1 : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TuasA1.DoorAOpen)
        {
            animator.enabled = true;
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -90f);
        }
    }
}
