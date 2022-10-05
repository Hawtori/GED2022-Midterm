using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{

    public abstract class Observer
    {
        public abstract void UpdateNotif();
    }

    public class Enemy : Observer
    {

        GameObject e;
        public Enemy(GameObject enemy)
        {
            this.e = enemy;
        }

        public override void UpdateNotif()
        {
            Debug.Log("Player has fallen");
            e.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }

}