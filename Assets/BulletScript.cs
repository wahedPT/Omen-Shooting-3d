using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float bulletSpeed;

    //List<GameObject> bulletList;
    // Start is called before the first frame update
    void Start()
    {
        //for(int i = 0; i < 20; i++)
        //{
        //    GameObject bulletobj = Instantiate(BulletPrefab, transform.GetChild(1).position, transform.rotation);

        //    bulletList.Add(bulletobj);
        //    bulletList[i].SetActive(false);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletobj = Instantiate(BulletPrefab, transform.GetChild(1).position, transform.rotation);
            bulletobj.transform.position = transform.GetChild(1).position;
            Rigidbody rb = bulletobj.GetComponent<Rigidbody>();
            rb.AddForce(bulletobj.transform.forward * bulletSpeed);
        }


        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        for (int i = 0; i < 20; i++)
        //        {
        //            if(bulletList[i].activeInHierarchy == false)
        //            {
        //                bulletList[i].SetActive(true);
        //                bulletList[i].transform.position = transform.GetChild(1).position;
        //                bulletList[i].transform.rotation = transform.GetChild(1).rotation;
        //                Rigidbody rb = bulletList[i].GetComponent<Rigidbody>();
        //                rb.AddForce(bulletList[i].transform.forward * bulletSpeed);
        //            }
        //        }
        //        //bulletobj.transform.position = transform.GetChild(1).position;
        //        //Rigidbody rb = bulletobj.GetComponent<Rigidbody>();
        //        //rb.AddForce(bulletobj.transform.forward * bulletSpeed);

        //}
    }
}
