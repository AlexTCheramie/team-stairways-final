using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is a simple character control script - 4/7/20
/// </summary>
public class Character_Movement : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMovement();    //enables the character to have simple motions
    }

    /// <summary>
    /// CharacterMovement provides the character with basic movement controls
    /// </summary>
    void CharacterMovement()
    {
        float x = Input.GetAxis("Horizontal");  //access the horizontal keys (left, right, a, d)
        float z = Input.GetAxis("Vertical");    //access the vertical keys (up, down, w, s)

        float rotateSpeed = 2.50f;    //speed of the character's rotation
        float moveSpeed = 5.0f;     //speed of the character's movement
        Vector3 turnVelocity = new Vector3(0f, x * rotateSpeed, 0f);    //the velocity of the rotations/is the Vector3 of the rotation movement

        transform.position += transform.forward * z * moveSpeed * Time.deltaTime;

        transform.Rotate(turnVelocity); //rotates the player left and right

    }
}
