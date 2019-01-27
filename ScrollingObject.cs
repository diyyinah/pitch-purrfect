using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Added Rigidbody2D to the ground and set it to Kinematic so only affected by script

public class ScrollingObject : MonoBehaviour
{

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        //make reference to rb2d
        //Checked for rb2d attached to GO script is attachedto and store reference in variable
        rb2d.velocity = new Vector2 (GameController.instance.scrollSpeed, 0);
        // set velocity.  moving 2 pieces of ground and column at same speed
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.gameOver == true)
        {
          rb2d.velocity = Vector2.zero;
          // stop any and all objects scrolling when game control says game over
        }
    }
}
