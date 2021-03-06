using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private Vector3 _cameraOffset;

    //Initilizes the offset at start of game
    private void Start()
    {
        //Initilizes the cameras position to be the difference between the cameras position and the players
        _cameraOffset = transform.position - _player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Set the cameras position to be the players positon plus the cameras offset
        //Camera will follow player
        transform.position = _player.transform.position + _cameraOffset;
    }
}
