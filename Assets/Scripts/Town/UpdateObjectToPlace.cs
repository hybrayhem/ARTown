using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateObjectToPlace : MonoBehaviour
{
    public void Activate(GameObject objectToPlace) {
        Debug.Log("UpdateObjectToPlace.Activate:" + objectToPlace.name);

        GameObject interaction = GameObject.Find("Interaction");

        // Get ARTapToPlaceObject component from Interaction object
        ARTapToPlaceObject arTapToPlaceObject = interaction.GetComponent<ARTapToPlaceObject>();

        // Set objectToPlace and enable ARTapToPlaceObject script
        arTapToPlaceObject.objectToPlace = objectToPlace;
        arTapToPlaceObject.enabled = true;
    }
}
