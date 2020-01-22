using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {
    
    public void go (float xSpeed, float ySpeed) {
        GetComponent<Rigidbody2D> ().velocity = new Vector2 (xSpeed, -ySpeed);
    }

    void Start () {
    }

    void OnBecameInvisible () {
        Destroy (this.gameObject);
    }
}