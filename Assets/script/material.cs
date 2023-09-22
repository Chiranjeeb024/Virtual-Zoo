using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class material : MonoBehaviour
{
    public Material material1; // Drag your first material here in the Unity Inspector
    public Material material2; // Drag your second material here in the Unity Inspector
    public float swapInterval = 1.0f; // Time interval between material swaps

    private Renderer rend;
    private bool isMaterial1Active = true;
    private float nextSwapTime;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = material1; // Set the initial material to material1
    }

    void Update()
    {
        // Check if it's time to swap materials
        if (Time.time >= nextSwapTime)
        {
            // Swap materials
            if (isMaterial1Active)
                rend.material = material2;
            else
                rend.material = material1;

            isMaterial1Active = !isMaterial1Active; // Toggle the active material
            nextSwapTime = Time.time + swapInterval; // Set the time for the next swap
        }
    }
}

