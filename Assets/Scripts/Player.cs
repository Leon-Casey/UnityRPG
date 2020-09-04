using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    Entity entity;

    int xp = 0;
    public int gearScore = 0;

    ArrayList targetsInRange = new ArrayList();


    //public Player(string name, int level, double hp, int xPos, int yPos)
    //{
    //    super(name, level, hp, xPos, yPos);
    //}

    #region getters setters
    public int getXp()
    {
        return xp;
    }

    public void setXp(int xp)
    {
        this.xp = xp;
    }

    public int getGearScore()
    {
        return gearScore;
    }

    public void setGearScore(int gearScore)
    {
        this.gearScore = gearScore;
    }
    #endregion

    public void attack()
    {
        getTargetsInRange();

        foreach(Entity target in targetsInRange)
        {
            //dealDmg(target, this.dmgRating);
            dealDmg(target, 5);
        }
    }

    public void levelUp(Entity e)
    {
        e.setLevel(e.getLevel() + 1);
    }

    public void getTargetsInRange()
    {
        Player target = new Player();
        target.gearScore = 0;
        this.targetsInRange.Add(target);
        //this.targetsInRange.Add(new Player("Bob", 1, 25, 5, 5));
    }

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
    }

    override protected void Start()
    {
    }

    override protected void Update()
    {

    }
}
