using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sizer : MonoBehaviour
{

    // Start is called before the first frame update
    public new Camera camera;

    void Start()
    {
        if (camera != null)
        {
            // Calculate the camera's view size
            float cameraHeight = 2f * camera.orthographicSize;
            float cameraWidth = cameraHeight * camera.aspect;

            // Calculate the corners of the camera's view
            Vector3 bottomLeftCorner = camera.transform.position - new Vector3(cameraWidth / 2f, cameraHeight / 2f, 0f);
            Vector3 bottomRightCorner = camera.transform.position + new Vector3(cameraWidth / 2f, -cameraHeight / 2f, 0f);
            Vector3 topLeftCorner = camera.transform.position + new Vector3(-cameraWidth / 2f, cameraHeight / 2f, 0f);
            Vector3 topRightCorner = camera.transform.position + new Vector3(cameraWidth / 2f, cameraHeight / 2f, 0f);

            // Print the positions of the camera's corner points
            Debug.Log("Bottom Left Corner: " + bottomLeftCorner);
            Debug.Log("Bottom Right Corner: " + bottomRightCorner);
            Debug.Log("Top Left Corner: " + topLeftCorner);
            Debug.Log("Top Right Corner: " + topRightCorner);
        }
        else
        {
            Debug.LogError("Camera reference is not assigned!");
        } 
    }
    
}
