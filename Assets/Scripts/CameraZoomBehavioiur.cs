using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraZoomBehavioiur : MonoBehaviour
{
    private Camera _camera;
    [SerializeField]
    private Vector2 _referenceAspectRatio;
    private Vector3 _startPos;
    private float _refratio;
    //[SerializeField]
    //private Vector3 _zoomScale = Vector3.one;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
        _refratio = _referenceAspectRatio.x / _referenceAspectRatio.y;
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if (_referenceAspectRatio.x <= 0 || _referenceAspectRatio.y <= 0)
        //    return;

        //Find the difference between the reference ration found and the current cameras aspect ratio
        double ratio = _refratio / _camera.aspect;
        //Round that ratio found
        ratio = Math.Round(ratio, 4);

        Vector3 scaledPosition = _startPos * (float)ratio;

        //transform.position = scaledPosition;
    }
}
