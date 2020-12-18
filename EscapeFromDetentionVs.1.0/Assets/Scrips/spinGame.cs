using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class spinGame : MonoBehaviour
{
    public SteamVR_Action_Boolean dropBlock;
    public SteamVR_Action_Single spinAction;
    public SteamVR_Action_Vector2 moveBlock;
    public float rotateSpeed;
    public Rigidbody rB;
    public float moveSpeed;
    

        
 

    // Update is called once per frame
    void Update()
    {
        // spins block using either trigger
        if (spinAction.axis > 0)
        {
            transform.Rotate(0, spinAction.axis * rotateSpeed, 0, Space.Self);
        }

        //Drop the block when you click the joystick
        if (dropBlock.GetState(SteamVR_Input_Sources.LeftHand))
        {
            rB.useGravity = true;
        }

        //move the block around the board
        if(moveBlock.changed && !rB.useGravity)
        {
            transform.position = new Vector3(transform.position.x + (moveBlock.axis.x * moveSpeed), transform.position.y, transform.position.z + (moveBlock.axis.y * moveSpeed));
        }

    }
}
