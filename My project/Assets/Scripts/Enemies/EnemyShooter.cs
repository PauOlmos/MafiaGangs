using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyShooter : MonoBehaviour
{
    // Start is called before the first frame update
    private Player_Movment player;
    public GameObject projectile;
    bool atack = true;
    public float atackSpeed;
    float atackSpeedReset;
    public float damage = 10f;
    public float hp;
    void Start()
    {
        player = GameObject.Find("Player").gameObject.GetComponent<Player_Movment>();
        atackSpeedReset = atackSpeed;
    }

    // Update is called once per frame
    void Update()
    {
       if (atack == true)
       {
            CreateProjectile();
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

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnCollisionStay(Collision collision)
    {

    }

    private void OnCollisionExit(Collision collision)
    {

    }

    void CreateProjectile() {
         float projectileSpeed = 10f;
         Vector3 shootDirection = (player.transform.position - transform.position).normalized;
        GameObject shoot = Instantiate(projectile, gameObject.transform.position, Quaternion.identity);
        shoot.GetComponent<Rigidbody>().velocity = new Vector3(shootDirection.x, shootDirection.y, 0f) * projectileSpeed;
    }
}
