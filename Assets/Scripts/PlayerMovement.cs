using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)) {
            animator.SetBool("IsMoving",true);
            animator.SetFloat("MoveX", 1f);
            animator.SetFloat("MoveY", 0f);
            transform.position +=  transform.right * (Time.deltaTime * 7);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)) {
            animator.SetBool("IsMoving",true);
            animator.SetFloat("MoveX", -1f);
            animator.SetFloat("MoveY", 0f);
            transform.position +=  transform.right * (Time.deltaTime * -7);
        }
        else if(Input.GetKey(KeyCode.UpArrow)) {
            animator.SetBool("IsMoving",true);
            animator.SetFloat("MoveX", 0f);
            animator.SetFloat("MoveY", 1f);
            transform.position +=  transform.up * (Time.deltaTime * 7);
        }
        else if(Input.GetKey(KeyCode.DownArrow)) {
            animator.SetBool("IsMoving",true);
            animator.SetFloat("MoveX", 0f);
            animator.SetFloat("MoveY", -1f);
            transform.position +=  transform.up * (Time.deltaTime * -7);
        }
        else
        {
            animator.SetBool("IsMoving",false);
        }
    }
}
