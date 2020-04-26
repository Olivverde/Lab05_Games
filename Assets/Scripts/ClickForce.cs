using UnityEngine;

public class ClickForce : MonoBehaviour
{
    public Camera cam;
    private RaycastHit objectToPush;
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out objectToPush))
            {
                if (objectToPush.collider.CompareTag("Target"))
                    objectToPush.rigidbody.AddForceAtPosition(objectToPush.normal * - 2, objectToPush.point, ForceMode.Impulse);
            }
        }
    }
}
