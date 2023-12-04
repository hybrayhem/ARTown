using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateObjectToPlace : MonoBehaviour
{
    public void Activate(GameObject objectToPlace) {
        // Get previous objectToPlace
        // GameObject previousObjectToPlace = GameObject.Find("Interaction").GetComponent<ARTapToPlaceObject>().objectToPlace;
        // VehicleDriver vehicleDriver = previousObjectToPlace.GetComponent<VehicleDriver>();
        // if(vehicleDriver != null) {
        //     vehicleDriver.enabled = false;
        // }

        Debug.Log("UpdateObjectToPlace.Activate:" + objectToPlace.name);
        // GameObject driveButtons = GameObject.Find("Drive Buttons");
        // switch(objectToPlace.name) {
        //     case "Plane":
        //     case "Car":
        //         driveButtons.SetActive(true);
        //         break;
        //     default:
        //         driveButtons.SetActive(false);
        //         break;
        // }

        GameObject interaction = GameObject.Find("Interaction");

        // Get ARTapToPlaceObject component from Interaction object
        ARTapToPlaceObject arTapToPlaceObject = interaction.GetComponent<ARTapToPlaceObject>();

        // Set objectToPlace and enable ARTapToPlaceObject script
        arTapToPlaceObject.objectToPlace = objectToPlace;
        arTapToPlaceObject.enabled = true;
    }
}
