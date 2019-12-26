using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("플레이어 애니메이션 속성")]
    public GameObject anim;
    private int score = 0;
    private Animator animator;


    void Start()
    {
        animator = anim.GetComponent<Animator>();
    }

    void Update()
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
        else
        {
            animator.SetBool("walk", false);
            animator.SetBool("jump", false);
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
   
   public  void AddScore(int addNum)
    {
        score += addNum;
    }
    public int getScore()
    {
        return score;
    }
}
