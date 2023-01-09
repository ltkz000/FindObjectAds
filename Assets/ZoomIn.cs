using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ZoomIn : MonoBehaviour
{
    private TouchControls controls;
    private Coroutine zoomCoroutine;
    private Transform camTrans;
    public Transform zoomTrans;

    private void Awake()
    {
        controls = new TouchControls();
        camTrans = Camera.main.transform;
    }

    private void OnEnable() 
    {
        controls.Enable();
    }

    private void OnDisable() 
    {
        controls.Disable();
    }
    
    private void Start() 
    {
        controls.Touch.SecondaryTouchContact.started += _ => ZoomStart();
        controls.Touch.SecondaryTouchContact.canceled += _ => ZoomEnd();

        controls.Touch.TestZoom.performed += DoZoomIn;
    }

    private void DoZoomIn(InputAction.CallbackContext obj)
    {
        Camera.main.orthographicSize--;
    }

    private void ZoomStart()
    {
        zoomCoroutine = StartCoroutine(ZoomDetection());
    }

    private void ZoomEnd()
    {
        StopCoroutine(zoomCoroutine);
    }

    IEnumerator ZoomDetection()
    {
        float previousDistance = 0f, distance = 0f; 
        while(true)
        {
            distance = Vector2.Distance(controls.Touch.PrimaryFinger.ReadValue<Vector2>(), controls.Touch.SecondaryFinger.ReadValue<Vector2>());

            if(distance > previousDistance)
            {
                Camera.main.orthographicSize++;
            }
            else if(distance < previousDistance)
            {
                Camera.main.orthographicSize--;
            }

            previousDistance = distance;
        }
        yield return null;
    }
}
