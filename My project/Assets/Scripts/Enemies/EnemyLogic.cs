using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLogic : MonoBehaviour
{
    private NavMeshAgent enemy;
    GameObject Player;
    public bool active = false;
    public Vector3 returnPosition;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        enemy = GetComponent<NavMeshAgent>();
        returnPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (active == true)
        {
            enemy.speed = 3.5f;
            enemy.SetDestination(Player.transform.position);
        }
        else if (active == false) {

            enemy.speed = 1.5f;
            enemy.SetDestination(returnPosition);
            
        }
    }
}
