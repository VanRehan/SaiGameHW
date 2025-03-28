using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // 5 Enemies variables

    //variables 1 
    public int health = 100;
    //variables 2
    public float speed = 3.5f;
    //variables 3 
    public int damage = 10;
    //variables 4 
    public float detectionRange = 5f;
    //variables 5 
    public bool isAlive = true;

    // 5 Enemies methods

    //Method 1
  public void DisplayHealth()
    {
        Debug.Log("Enemy Health: " + health);
    }
    //Method 2
    public void UpdateSpeed(float newSpeed)
    {
        speed = newSpeed;
        Debug.Log("Enemy Speed has been updated to: " + speed);
    }
    //Method 3
        public void UpdateDamage(int newDamage)
    {
        damage = newDamage;
        Debug.Log("Enemy Damage has been updated to: " + damage);
    }
    //Method 4
       public void UpdateDetectionRange(float newRange)
    {
        detectionRange = newRange;
        Debug.Log("Enemy Detection Range has been updated to: " + detectionRange);
    }
    //Method 5
        public void SetAliveStatus(bool status)
    {
        isAlive = status;
        Debug.Log("Enemy Alive Status has been set to: " + isAlive);
    }
}
