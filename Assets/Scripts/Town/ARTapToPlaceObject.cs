using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems; // using UnityEngine.Experimental.XR;

public class ARTapToPlaceObject : MonoBehaviour
{
    public GameObject placementIndicator;

    // private ARSessionOrigin arOrigin;
    private ARRaycastManager arRaycastManager;
    // private ARPlaneManager arPlaneManager;
    private Pose placementPose; 
    private bool placementPoseIsValid = false;

    void Start()
    {
        // arOrigin = FindObjectOfType<ARSessionOrigin>();
        arRaycastManager = FindObjectOfType<ARRaycastManager>();
        // arPlaneManager = FindObjectOfType<ARPlaneManager>();
    }

    void Update()
    {
        UpdatePlacementPose();
        UpdatePlacementIndicator();
    }

    private void UpdatePlacementIndicator() {
        if(placementPoseIsValid) {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        } else {
            placementIndicator.SetActive(false);
        }
    }

    private void UpdatePlacementPose() {
        if (Camera.current == null) {
            Debug.LogWarning("Camera.current is null");
            return;
        }
        if (arRaycastManager == null) {
            Debug.LogWarning("arRaycastManager is null");
            return;
        }

        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();

        arRaycastManager.Raycast(screenCenter, hits, TrackableType.Planes);

        placementPoseIsValid = hits.Count > 0; 
        if(placementPoseIsValid) {  
            placementPose = hits[0].pose;
        }
    }
}
