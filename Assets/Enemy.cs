using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent nav;
    public Vector3 pos;
    public Transform Player;
    public static bool TriggerEnemy;
    public int life = 1;

    // Start is called before the first frame update
    void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
        TriggerEnemy = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (TriggerEnemy == true)
        {
            nav.SetDestination(Player.position);
        }
    }

    // Update is called once per frame
   
}
