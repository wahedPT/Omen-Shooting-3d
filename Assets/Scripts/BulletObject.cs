using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObject : MonoBehaviour
{
    
    private void OnEnable()
    {
        
        transform.GetComponent<Rigidbody>().WakeUp();
        Invoke("hideBullet", 2.0f);
    }
    
    void hideBullet()
    {
        
        gameObject.SetActive(false);
    }
    
    private void OnDisable()
    {
       
        transform.GetComponent<Rigidbody>().Sleep();
        CancelInvoke();
    }
    private void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "Enemy")
        {
            Destroy(Col.gameObject);
            
            gameObject.SetActive(false);
            // scoreScript.scoreValue += 5;
            scoreScript.scoreValue += 5;
        }
    }
}
