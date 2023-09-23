using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawn : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene to load when triggered

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object has a specific tag (e.g., "Player")
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
