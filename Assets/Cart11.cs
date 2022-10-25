using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart11 : MonoBehaviour
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
        gameRole.results[0] = 11;
    }
}
