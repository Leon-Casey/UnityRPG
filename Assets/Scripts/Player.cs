using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    Entity entity;

    int xp = 0;
    public int gearScore = 0;

    ArrayList targetsInRange = new ArrayList();

    //PRIMARY STATS (ones that affect skills/spells and damage)
    //==============
    // heavy melee weaps
    public int strength;

    // quick melee weaps
    public int dexterity;

    // magic
    public int intelligence;

    //SECONDARY STATS (ones that affect other things like hp, bonus xp, item find)
    //===============
    // health
    public int stamina;

    // bonus xp
    public int focus;

    // item find
    public int luck;




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
            DealDmg(target, 5);
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

    override public void DealDmg(Entity target, int dmg)
    {
        Debug.Log(this.name + "deals " + dmg + " damage to " + target.getName() + "!");
        target.TakeDmg(dmg);
    }

    override public void TakeDmg(int dmg)
    {
        this.hp -= dmg;
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
    }

    override protected void Start()
    {
    }

    override protected void Update()
    {

    }
}
