using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : Entity
{
    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform homePosition;

    override protected void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    override protected void Update()
    {
        CheckDistance();
    }

    void CheckDistance()
    {
        //if (Vector3.Distance(target.position, transform.position) <= chaseRadius / 2)
        //{
            if (Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            }
        //}
    }


    override public void DealDmg(Entity target, int dmg)
    {
        Debug.Log(this.name + "deals " + dmg + " damage to " + target.getName() + "!");
        target.TakeDmg(dmg);
    }

    override public void TakeDmg(int dmg)
    {
        int netDmg;


        netDmg = dmg + Random.Range(0, (int)(dmg * 0.15));

        this.hp -= netDmg;
        if (this.hp <= 0)
        {
            Die();
        }
        else
        {
            Debug.Log(name + "'s hp is now " + hp);
        }
    }

    override public void Die()
    {
        Debug.Log(this.name + " died!");
        Destroy(gameObject);
    }



    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    //    }
    //}
}
