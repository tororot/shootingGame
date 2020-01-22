using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour {

    private string enemyTag = "enemy";


    void Start () {
        float x = Random.value-0.5f;
        GetComponent<Rigidbody2D> ().velocity
         = new Vector2 (x, 5.0f);
    }

    void Update () {

    }

    void OnBecameInvisible () {
        Destroy (this.gameObject);
    }

    void OnTriggerEnter2D (Collider2D collider) {
        if (collider.gameObject.tag == enemyTag) {
            Destroy (this.gameObject);
        }

    }
}