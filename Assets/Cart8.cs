using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Cart8 : MonoBehaviour
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
        gameRole.results[0] = 8;
       
        gameRole.primeNumbers.Add("Cart8");







    }
}
