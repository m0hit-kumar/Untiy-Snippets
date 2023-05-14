# Sizer Script

This script is written in C# for the Unity game engine. It calculates and prints the positions of the corner points of the camera's view in the game world.

## How it Works

The script performs the following steps:

1. It checks if a camera reference is assigned.
2. If a camera reference is assigned, it calculates the height and width of the camera's view based on its orthographic size and aspect ratio.
3. It determines the positions of the four corner points of the camera's view in the game world.
4. It prints the positions of the camera's corner points in the Unity Editor's console.

## Code Explanation

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sizer : MonoBehaviour
{
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
```

#Variable
camera: A reference to a Camera object.
#Method
Start(): A Unity callback method that is called before the first frame update. It performs the following steps:
- It checks if the camera reference is assigned.
- If the camera reference is assigned, it calculates the height and width of the camera's view based on its orthographic size and aspect ratio.
- It determines the positions of the four corner points of the camera's view in the game world.
- It prints the positions of the camera's corner points using Debug.Log().
- If the camera reference is not assigned, it logs an error message using Debug.LogError().
#How to Use
- Attach the Sizer script to a game object in the Unity scene.
- Assign a camera object to the camera field in the Unity editor.
- Run the game.
- Check the console output in the Unity Editor. The positions of the camera's corner points will be displayed.
**Note**: Make sure the assigned camera has the desired orthographic size and aspect ratio configured.

#Example Output

```
Bottom Left Corner: (-5.0, 0.0, 0.0)
Bottom Right Corner: (5.0, 0.0, 0.0)
Top Left Corner: (-5.0, 10.0, 0.0)
Top Right Corner: (5.0, 10.0, 0.0)
```





