using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Entity : MonoBehaviour
{
    public string entityName;
    public int level;
    
    public double hp;
    public int dmgRating;

    public float moveSpeed;


    int xPos;
    int yPos;

    //public Entity(string name, int level, double hp, int xPos, int yPos)
    //{
    //    this.name = name;
    //    this.level = level;
    //    this.hp = hp;
    //    this.xPos = xPos;
    //    this.yPos = yPos;
    //}

    #region getters setters
    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public int getLevel()
    {
        return level;
    }

    public void setLevel(int level)
    {
        this.level = level;
    }

    public double getHp()
    {
        return hp;
    }

    public void setHp(double hp)
    {
        this.hp = hp;
    }

    public int getxPos()
    {
        return xPos;
    }

    public void setxPos(int xPos)
    {
        this.xPos = xPos;
    }

    public int getyPos()
    {
        return yPos;
    }

    public void setyPos(int yPos)
    {
        this.yPos = yPos;
    }

    public int getDmgRating()
    {
        return dmgRating;
    }

    public void setDmgRating(int dmgRating)
    {
        this.dmgRating = dmgRating;
    }
    #endregion

    abstract public void DealDmg(Entity target, int dmg);

    abstract public void TakeDmg(int dmg);

    abstract public void Die();

    // Start is called before the first frame update
    abstract protected void Start();

    // Update is called once per frame
    abstract protected void Update();
}
