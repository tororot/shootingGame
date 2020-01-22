using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLife : MonoBehaviour
{
    public int life;

    private string bulletTag = "bullet";

    void Start()
    {
        
    }

    void Update()
    {
        if(life < 0){
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == bulletTag){
            life--;
        }
    }
}
