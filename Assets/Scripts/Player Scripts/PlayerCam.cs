using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensitivityX;
    public float sensitivityY;
    public Transform playerOrientation;
    public float xRotation;
    public float yRotation;

    private void Start()
    {
        //Makes the cursor locked on the middle of the screen.
        Cursor.lockState = CursorLockMode.Locked;

        //You will not see the cursor.
        Cursor.visible = false;
    }

    private void Update()
    {
        //This gets the mouse X input.
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivityX;

        //This gets the mouse Y input.
        float mouseY = -Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivityY;

        //This is the way Unity handles rotations and inputs.
        yRotation += mouseX;
        xRotation += mouseY;

        //This will constraint the player from only looking 90 degrees up and down.
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //This rotates the camera and orientation of the player.
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        playerOrientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }

}
