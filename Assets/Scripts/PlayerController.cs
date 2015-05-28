//-----------------------------------------
//   PlayerController.cs
//
//   Jason Walters
//   http://glitchbeam.com
//   @jasonrwalters
//
//   edit 5/25/2015
//-----------------------------------------

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float boundsX;
    public float speed;
    public float tilt;

    private Rigidbody rb;
    private float inputHorizontal;

    void Start()
    {
        // reference components
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // grabs input in update loop for best accuracy
        PlayerInput();
    }

    void FixedUpdate()
    {
        // run movement function to handle rigidbody physics
        Movement();
    }

    void PlayerInput()
    {
        if (BodySourceView.bodyTracked)
        {
            // fetch hand positions
            Vector3 handLeft = BodySourceView.jointObjs[7].position;
            Vector3 handRight = BodySourceView.jointObjs[11].position;

            // calc angle of hands
            float angle = Mathf.Atan2(handRight.y - handLeft.y, handRight.x - handLeft.x) * Mathf.Rad2Deg;

            // convert angle rotation to movement values
            inputHorizontal = Mathf.Lerp(1.0f, -1.0f, Mathf.InverseLerp(-45.0f, 45.0f, angle));
        }
        else
        {
            // fetch our input for movememnt
            inputHorizontal = Input.GetAxis("Horizontal");
        }
    }

    void Movement()
    {
        // update player velocity
        Vector3 input = new Vector3(inputHorizontal, 0.0f, 0.0f);

        // update player velocity
        rb.velocity = input * speed;

        // apply hover effect, and clamp player within bounds
        Vector3 pos = rb.position;
        rb.position = new Vector3(Mathf.Clamp(pos.x, -boundsX, boundsX), pos.y, pos.z);

        // apply tilt effect to our rotation
        float tiltZ = rb.velocity.x * -tilt;
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, tiltZ);
    }
}