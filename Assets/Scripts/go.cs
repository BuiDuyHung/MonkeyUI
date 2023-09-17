using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go : MonoBehaviour
{
    public Rigidbody2D rd;
    public Animator anim;
    public int speed=4;
    public float leftRight;
    public bool isFacingRight = true;

    void Start()
    {
        
    }

    void Update()
    {
        leftRight = Input.GetAxisRaw("Horizontal");
        rd.velocity = new Vector2(speed*leftRight, rd.velocity.y);

        if (isFacingRight==true && leftRight==-1) {
            transform.localScale = new Vector3(-1, 1, 1);
            isFacingRight = false;
        }
        if (isFacingRight == false && leftRight == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
            isFacingRight = true;
        }
        
        // animation
        anim.SetFloat("go", Mathf.Abs(leftRight));
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("attack");
        }
    }
}
