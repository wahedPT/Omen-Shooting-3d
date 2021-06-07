using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObject : MonoBehaviour
{
    //when my setactive of my bullet is going to be true this fun will trigger
    private void OnEnable()
    {
        //when my bullet is setactive true rigidbody wakes up
        transform.GetComponent<Rigidbody>().WakeUp();
        Invoke("hideBullet", 2.0f);
    }
    //hide it after 5 sec
    void hideBullet()
    {
        
        gameObject.SetActive(false);
    }
    //tjis will trigger when it is setActive to false
    //so whenever bullet setactive is false this method will call the cancel all the invoke
    private void OnDisable()
    {
        //when my bullet is setactive false rigidbody sleep then force will not continue to apply
        transform.GetComponent<Rigidbody>().Sleep();
        CancelInvoke();
    }
    private void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "Enemy")
        {
            Destroy(Col.gameObject);
            //hide this make it false when it collides with enemy
            gameObject.SetActive(false);
            // scoreScript.scoreValue += 5;
            scoreScript.scoreValue += 5;
        }
    }
}
