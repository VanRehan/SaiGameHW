using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// em có tạo class Enemy để nó tham chiếu CurrentHP
public class FindEnemy : MonoBehaviour
{
    public List<Enemy> enemyList;

    //----------------------Edit below here --------------------
    public Enemy FindEnemyWithSmallestHealth()
    {
        if (enemyList == null || enemyList.Count == 0)
            return null;
        Enemy minEnemy = enemyList[0];
        foreach (Enemy enemy in enemyList)
        {
            if (enemy.currentHP < minEnemy.currentHP)
                minEnemy = enemy;
        }
        return minEnemy;
    }

    public Enemy FindEnemyWithLargestHealth()
    {
        if (enemyList == null || enemyList.Count == 0)
            return null;
        Enemy maxEnemy = enemyList[0];
        foreach (Enemy enemy in enemyList)
        {
            if (enemy.currentHP > maxEnemy.currentHP)
                maxEnemy = enemy;
        }
        return maxEnemy;
    }
    //----------------------Edit above here --------------------
}
