using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  
    public float moveSpeed;
    public GameObject ParticleEffectPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        //ref
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        //collision.gameObject.SetActive(false);
        Instantiate(ParticleEffectPrefab, transform.position, Quaternion.identity);
    }

}
