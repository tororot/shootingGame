using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [Header ("移動スピード")] public float speed;
    public GameObject bullet;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start () {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update () {
        move ();

        shot ();

    }

    public void shot () { 
        if(Input.GetKey(KeyCode.Z)){
            Vector2 pos = new Vector2(
                transform.position.x,transform.position.y+1.2f);
			Instantiate(bullet, pos, Quaternion.identity);
        }

    }

    public void move () {
        float horizontalKey = Input.GetAxis ("Horizontal");
        float verticalKey = Input.GetAxis ("Vertical");

        float xSpeed = 0.0f;
        if (horizontalKey > 0) {
            xSpeed = speed;
        } else if (horizontalKey < 0) {
            xSpeed = -speed;
        } else {
            xSpeed = 0.0f;
        }

        float ySpeed = 0.0f;
        if (verticalKey > 0) {
            ySpeed = speed;
        } else if (verticalKey < 0) {
            ySpeed = -speed;
        } else {
            ySpeed = 0.0f;
        }

        rb.velocity = new Vector2 (xSpeed, ySpeed);

    }
}