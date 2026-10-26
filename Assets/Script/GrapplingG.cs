using UnityEngine;

public class GrapplingG : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask what;
    public Transform gunTip, camera;

    void Awake(){
        lr = GetComponent<LineRenderer>();


    }

    void Update(){
        if (Input.GetMouseButtonDown(0))
        {
            StartGrapple();
        }
        else if (Input.GetMouseButtonUp(0)){
            StopGrapple();
        }
    }

    void StartGrapple(){
        RaycastHit hit;
        if(Physics.Raycast()){
            
        }
    }

    void StopGrapple(){
        
    }
}
