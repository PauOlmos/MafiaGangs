using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemyLogic enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
          enemy.active = EnemyPathfindTrue(true);
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
          enemy.active = EnemyPathfindTrue(false);
        }
    }

    bool EnemyPathfindTrue(bool hasEnter) {

        return hasEnter;
    }
}
