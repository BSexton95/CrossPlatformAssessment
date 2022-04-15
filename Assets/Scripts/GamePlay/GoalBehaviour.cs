using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GoalBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("Worked");

        //Loads the end scene When player has reached the goal
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
