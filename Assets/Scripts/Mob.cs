using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : Entity
{

    override public void dealDmg(Entity target, int dmg)
    {
        Debug.Log(this.name + "deals " + dmg + " damage to " + target.getName() + "!");
        target.takeDmg(dmg);
    }

    override public void takeDmg(int dmg)
    {
        this.hp -= dmg;
        if (this.hp <= 0)
        {
            die();
        }
        else
        {
            Debug.Log(name + "'s hp is now " + hp);
        }
    }

    override public void die()
    {
        Debug.Log(this.name + " died!");
        Destroy(gameObject);
    }

    override protected void Start()
    {
    }

    override protected void Update()
    {

    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    //    }
    //}
}
