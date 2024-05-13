using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMele : MonoBehaviour
{
    // Start is called before the first frame update
    private Player_Movment player;
    bool canAtack = false;
    bool atack = true;
    public float atackSpeed;
    float atackSpeedReset;
    public float damage = 10f;
    public float hp;
    void Start()
    {
        player = GameObject.Find("Player").gameObject.GetComponent<Player_Movment>();
    }

    // Update is called once per frame
    void Update()
    {
        atackSpeedReset = atackSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player" && canAtack == false) {
            canAtack = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Player" && canAtack == true)
        {
            
                if (atack == true)
                {
                    player.hp = player.hp - damage;
                    atack = false;
                }
                else
                {
                    if (atackSpeed >= 0)
                    {
                        atackSpeed -= Time.deltaTime;
                    }
                    else
                    {
                        atack = true;
                        atackSpeed = atackSpeedReset;
                    }


                }

            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Player") {
            canAtack = false;
        }
    }
}