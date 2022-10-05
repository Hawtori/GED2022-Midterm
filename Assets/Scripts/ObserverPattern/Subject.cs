using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObserverPattern
{
    public class Subject
    {
        List<Observer> observers = new List<Observer>();

        public void Notify()
        {
            foreach(Observer o in observers)
            {
                o.UpdateNotif();
            }
        }
        
        public void AddObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            for(int i = 0; i < observers.Count; i++)
            {
                if(observers[i] == o)
                {
                    observers.RemoveAt(i);
                }
            }
        }
    }
}
