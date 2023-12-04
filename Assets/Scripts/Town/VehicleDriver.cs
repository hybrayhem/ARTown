using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleDriver : MonoBehaviour
{
    public float speed = 0.001f;
    public float rotationSpeed = 0.01f;

    void Update () {
	    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            // Get movement of the finger since last frame
            // var touchDeltaPosition:Vector2 = Input.GetTouch(0).deltaPosition;
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Move object across XY plane
            transform.Translate (touchDeltaPosition.x * speed, 0, touchDeltaPosition.y * speed);

            Debug.Log("New Position: " + transform.position);
	    }
    }
    // private GameObject vehicle;
    
    // public float speed = 10.0f;
    // public float rotationSpeed = 100.0f;

    // void Start()
    // {
    //     Debug.Log("VehicleDriver");

    //     GameObject interaction = GameObject.Find("Interaction");
    //     ARTapToPlaceObject arTapToPlaceObject = interaction.GetComponent<ARTapToPlaceObject>();
    //     vehicle = arTapToPlaceObject.objectToPlace;
    // }

    // // void Update()
    // // {
        
    // // }

    // public void MoveForward()
    // {
    //     float translation = speed * Time.deltaTime;
    //     vehicle.transform.Translate(0, 0, translation);
    // }

    // public void MoveBackward()
    // {
    //     float translation = speed * Time.deltaTime;
    //     vehicle.transform.Translate(0, 0, -translation);
    // }

    // public void RotateLeft()
    // {
    //     float rotation = -rotationSpeed * Time.deltaTime;
    //     vehicle.transform.Rotate(0, rotation, 0);
    // }

    // public void RotateRight()
    // {
    //     float rotation = rotationSpeed * Time.deltaTime;
    //     vehicle.transform.Rotate(0, rotation, 0);
    // }
}
