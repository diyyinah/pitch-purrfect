using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{

    public float maxPitch = 500f;
    public float maxHeight = 5.5f;
    // public float upForce = 200f;
    //
    private bool isDead = false;
    private Rigidbody2D rb2d;
    public pitchv2 PitchFetcher;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {

      if (isDead == false)
      {
        // transform.position = new Vector3(0, PitchFetcher.pitchValue / 120 - 2, 0);
        float normalizedPitch = PitchFetcher.pitchValue / maxPitch;
        float height = normalizedPitch * maxHeight;
        transform.localPosition = new Vector3(0,height,0);
        Debug.Log(PitchFetcher.pitchValue + " " + height);
      }
      // Set maximum to 0, min to 5.5

        //if (isDead == false)
        //{
          //if (Input.GetMouseButtonDown(0)) {
            //rb2d.velocity = Vector2.zero;
            // If player is not dead and has clicked the button,
            // Means player will be rising because the player has flapped,
            // Or falling because they're affected by gravity
            //rb2d.AddForce(new Vector2(0, upForce));
            // x has 0 units of force because it's the world moving
          //}
        //}

        void OnCollisionEnter2D () //this is Unity API, will be looking for this
        {
          isDead = true;
          GameController.instance.CatDied ();
          // once it's true, can't flap anymore because check will fail
        }
    }
}
