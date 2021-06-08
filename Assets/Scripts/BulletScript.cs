using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    [SerializeField]
    private float bulletSpeed = 500;

    List<GameObject> bulletList;
    // Start is called before the first frame update
    void Start()
    {
        bulletList = new List<GameObject>();
        for(int i =0; i < 20; i++)
        {
            GameObject bulletobj = Instantiate(BulletPrefab, transform.GetChild(1).position, transform.rotation);
            bulletobj.SetActive(false);
            bulletList.Add(bulletobj);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            for(int i = 0; i < bulletList.Count; i++)
            {
                //if my bullet is active in hierarchy it is in use
                //going to use next bullet in the pool
                //the bullet which is not in use break it
                if(bulletList[i].activeInHierarchy==false)
                {
                    bulletList[i].transform.position = transform.GetChild(1).position;
                    bulletList[i].transform.rotation = transform.GetChild(1).rotation;
                    bulletList[i].SetActive(true);
                    Rigidbody rb = bulletList[i].GetComponent<Rigidbody>();
                    rb.AddForce(bulletList[i].transform.forward * bulletSpeed);
                    break;
                }
            }

           /* GameObject bulletobj = Instantiate(BulletPrefab, transform.GetChild(1).position, transform.rotation);
            bulletobj.transform.position = transform.GetChild(1).position;
            Rigidbody rb = bulletobj.GetComponent<Rigidbody>();
            rb.AddForce(bulletobj.transform.forward * bulletSpeed);*/
        }


        
    }
}
