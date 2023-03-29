using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repel : MonoBehaviour
{
    [SerializeField] private InputController input = null;

    private bool desiredRepel;

    void Start()
    {
        
    }

    void Update()
    {
        desiredRepel |= input.RetrtieveRepelInput();
    }

    private void FixedUpdate()
    {
        if(desiredRepel)
        {
            print("REPEL");
            desiredRepel = false;
        }
    }
}
