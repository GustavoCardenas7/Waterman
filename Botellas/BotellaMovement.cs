using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotellaMovement : MonoBehaviour
{
    public Transform[] waypoints;
    int cur = 0;
    public float speed = 0.3f;
    private Sprite sprite;

    void FixedUpdate () {
    // Waypoint not reached yet? then move closer
        if (transform.position != waypoints[cur].position) {
            Vector2 p = Vector2.MoveTowards(transform.position,
                                            waypoints[cur].position,
                                            speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        // Waypoint reached, select next one
        else cur = (cur + 1) % waypoints.Length;
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Water-Man") {
            col.gameObject.GetComponent<SpriteRenderer>().color = new Color(176, 176, 176, 255); 
            //Destroy(col.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Water-Man") {
            col.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255); 
            //Destroy(col.gameObject);
        }
    }
}
