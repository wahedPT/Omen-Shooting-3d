using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public float speed;
    public float jumpSpeed;
    Animator anim;

    void Start()
    {
        
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        ////rotation
        float xAxis = Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(0, xAxis, 0) * transform.rotation;
        //movement

        float xvalue = Input.GetAxis("Horizontal");
        float Yvalue = Input.GetAxis("Vertical");

        if (Mathf.Abs(Yvalue) > 0.0)
        {
            transform.Translate(new Vector3(0, 0, Yvalue * speed * Time.deltaTime));
            //anim.SetBool("isRun", true);
            //anim.SetBool("isIdle", false);

            //if (Yvalue > 0.0)
            //{
            //    anim.SetBool("isRun", true);
            //}
            //else
            //{
            //    anim.SetBool("backWalk", true);
            //}
        }
        else
        {
            //anim.SetBool("isRun", false);
        }

        if (Mathf.Abs(xvalue) > 0.0)
        {
            transform.Translate(new Vector3(xvalue * speed * Time.deltaTime, 0, 0));
            //anim.SetBool("leftWalk", true);
            //anim.SetBool("isIdle", false);

            //if (xvalue > 0.0)
            //{
            //    //right anim
            //}
            //else
            //{
            //    //left anim
            //}
        }

        anim.SetFloat("XAxis", xvalue);
        anim.SetFloat("YAxis", Yvalue);

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        //    anim.SetBool("isRun", true);
        //    anim.SetBool("isIdle", false);

        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        //    anim.SetBool("backWalk", true);
        //    anim.SetBool("isIdle", false);
        //}
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        //    anim.SetBool("leftWalk", true);
        //    anim.SetBool("isIdle", false);
        //}
        //else if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        //    anim.SetBool("rightWalk", true);
        //    anim.SetBool("isIdle", false);
        //}
        //else
        //{
        //    anim.SetBool("isIdle", true);
        //    anim.SetBool("isRun", false);
        //}
        //if(Input.get)



        //else
        //{
        //    anim.SetTrigger("idle");
        //}

        //    if (Input.GetKey(KeyCode.S))
        //{

        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        //}
    }
    
}
