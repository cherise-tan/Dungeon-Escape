using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [SerializeField] float runSpeed = 5f;

    Rigidbody2D myRigidBody;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Run();
        flipSprite();

        
    }

    private void Run()
    {
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal"); // value is between -1 to +1
        // this says to get the axis (it is the horizontal axis)

        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidBody.velocity.y);
        // creates a new vector2, made up of the controlthrow (i.e. x axis), and setting the y axis to be whatever the current velocity is

        myRigidBody.velocity = playerVelocity; //then sets the player rigidbody velocity to be this new velocity


    }
    private void flipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
        // when the absolute value of the movement is greater than 0 (i.e. if there is any movement at all)
        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(myRigidBody.velocity.x), 1);
            //sets the local scale to be a new vector 2: the x will be either -1 or +1 (cos of Mathf.Sign)
            // Keep y axis the same (1 -> want to keep it the same scale)

        }
        
        
        //if player moving horizontally
        {
            //reverse current scaling of x axis
        }
    }


    //Mathf.abs returns the absolute value (if.e. converts a negative to a positive number)
        //Mathf.sign - if float is positive it will return 1, if it is negative it will return -1
}

