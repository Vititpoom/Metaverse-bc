using UnityEngine;
using System.Collections;

public class CameraRaycast : MonoBehaviour
{
    public Camera camerause;

    void Start()
    {
       
    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = camerause.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 10000))
        {
            Debug.DrawLine(camerause.transform.position, hit.point, Color.red);
            Debug.Log("Hit" + hit.point);
            //Transform objectHit = hit.transform;

            // Do something with the object that was hit by the raycast.
        }
    }
}