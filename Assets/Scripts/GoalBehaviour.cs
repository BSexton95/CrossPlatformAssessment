using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoalBehaviour : MonoBehaviour
{
    [SerializeField]
    private Text _vitoryText;
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Finish"))
    //        _vitoryText.enabled = true;
    //}

    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("Worked");
        print("Worked");
        ;
        
    }
}
