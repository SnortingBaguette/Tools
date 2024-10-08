using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePositionToWorld : MonoBehaviour
{

    public Camera mainCamera;
    public LayerMask goundLayerMask;
    Ray cameraToWorldRay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraToWorldRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(cameraToWorldRay, out RaycastHit raycastHit, float.MaxValue, goundLayerMask))
        {
            transform.position = raycastHit.point;
        }
    }
}
