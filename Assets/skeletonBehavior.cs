using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeletonBehavior : MonoBehaviour
{

    Animator anim;
    float speed = 1.5f;
    float rotSpeed = 80f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            anim.SetBool("isWalking", true);
            transform.position += Vector3.left * speed * Time.deltaTime;
            anim.SetInteger("state", 1);
        }

        else if (Input.GetKey(KeyCode.RightArrow)) {
            anim.SetBool("isWalking", true);
            transform.position += Vector3.right * speed * Time.deltaTime;
            anim.SetInteger("state", 1);
        }

        else if (Input.GetKey(KeyCode.UpArrow)) {
            anim.SetBool("isWalking", true);
            transform.position += Vector3.up * speed * Time.deltaTime;
            anim.SetInteger("state", 1);
        }

        else if (Input.GetKey(KeyCode.DownArrow)) {
            anim.SetBool("isWalking", true);
            transform.position += Vector3.down * speed * Time.deltaTime;
            anim.SetInteger("state", 1);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("isWalking", true);
            transform.position += Vector3.down * speed * Time.deltaTime;
            anim.SetInteger("state", 1);
        }
        else if (Input.GetKey(KeyCode.R))
        {
            anim.SetBool("isWalking", false);
            transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
            anim.SetInteger("state", 0);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            anim.SetBool("isWalking", false);
            transform.Rotate(Vector3.up, -rotSpeed * Time.deltaTime);
            anim.SetInteger("state", 0);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("isWalking", true);
            anim.SetInteger("state", 2);
        }
        else {
            anim.SetBool("isWalking", false);
            anim.SetInteger("state", 0);
        }
    }
}
