using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class ObserverManager : MonoBehaviour
    {
        public GameObject enemy;

        Subject sub = new Subject();

        private void Start()
        {
            Enemy square = new Enemy(enemy);
            sub.AddObserver(square);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            sub.Notify();
        }
    }
}
