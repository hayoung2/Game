using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject anim;
    private Animator animator;
    private ButtonManager startBtn;

    void Start()
    {
        animator = anim.GetComponent<Animator>();
        startBtn = GetComponent<ButtonManager>();
    }

    void Update()
    {
        if (startBtn.GetIsStart())
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                WalkAnimation();
                transform.Translate(Vector3.left * 1 * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                WalkAnimation();
                transform.Translate(Vector3.right * 1 * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                JumpAnimation();
                transform.Translate(Vector3.up * 4 * Time.deltaTime);

            }
        }
    }
    void WalkAnimation()
    {
        animator.SetBool("walk", true);
    }

    void JumpAnimation()
    {
        animator.SetBool("walk", false);
        animator.SetBool("jump", true);
        
    }

}
