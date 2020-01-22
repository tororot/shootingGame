using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFactory : MonoBehaviour {

    [Header ("敵")] public GameObject enemy;
    [Header ("出撃間隔")] public float waitingTime;
    [Header ("出撃方向x")] public float xSpeed;
    [Header ("出撃方向y")] public float ySpeed;

    void Awake () {
        InvokeRepeating ("createEnemy", waitingTime, waitingTime);
    }

    void Update () {

    }

    public void createEnemy () {
        GameObject e = Instantiate (enemy, 
        new Vector2(transform.position.x,
        transform.position.y - 1.0f), 
        Quaternion.identity);
        enemyController enemyController = e.GetComponent<enemyController> ();
        enemyController.go (xSpeed, ySpeed);
    }

}