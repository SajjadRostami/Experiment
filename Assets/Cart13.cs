using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Cart13 : MonoBehaviour
{
    private GameRole gameRole;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        

    }
    void OnMouseDown()
    {
        transform.localRotation *= Quaternion.Euler(0, 180, 0);
        gameRole = FindObjectOfType<GameRole>();
        gameRole.results[0] = 13;
        gameRole.primeNumbers.Add("Cart13");
    }
}
