using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private Vector3 _cameraPosition;

    // Update is called once per frame
    void Update()
    {
        transform.position = _player.transform.position + _cameraPosition;
        
    }
}
