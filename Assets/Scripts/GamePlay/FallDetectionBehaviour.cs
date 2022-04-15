using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetectionBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;

    // Update is called once per frame
    void Update()
    {
        //If the player falls off the track...
        if (_player.transform.position.y <= -10)
        {
            //...player will be set back to starting position
            _player.transform.position = new Vector3(14.4f, 0.72f, 0.21f);
        }
    }
}
