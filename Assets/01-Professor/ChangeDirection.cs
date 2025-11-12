using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ChangeDirection : MonoBehaviour
{

    private Animator anim;
    private float horixontalMove;
    private float verticalMove;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horixontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        //Horizontal move
        if (horixontalMove < 0)
        {
            anim.SetInteger("Direction", 3);
        }
        if (horixontalMove > 0)
        {
            anim.SetInteger("Direction", 1);
        }

        //Vertical move
        if (verticalMove < 0)
        {
            anim.SetInteger("Direction", 2);
        }
        if (verticalMove > 0)
        {
            anim.SetInteger("Direction", 0);
        }
    }
}
