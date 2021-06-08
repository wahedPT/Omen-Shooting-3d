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
        //0.0 key is not pressed
        //only 1 check 
        if (Mathf.Abs(Yvalue) > 0.0)
        {
            transform.Translate(new Vector3(0, 0, Yvalue * speed * Time.deltaTime));
           
        }
     

        if (Mathf.Abs(xvalue) > 0.0)
        {
            transform.Translate(new Vector3(xvalue * speed * Time.deltaTime, 0, 0));
           
        }

        anim.SetFloat("XAxis", xvalue);
        anim.SetFloat("YAxis", Yvalue);



        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpSpeed, 0));
        }
    }
   



    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Coin")
        {
            Destroy(other.gameObject);
            scoreScript.scoreValue += 1;
        }
            
    }



}
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
//public void OnCollisionEnter(Collision collision)
//{
//    if (collision.gameObject.CompareTag("Grounded"))
//    {
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpSpeed, 0));
//        }
//    }            
//}