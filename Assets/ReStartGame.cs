using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class ReStartGame : MonoBehaviour
{
    public Renderer m_renderer;
    private GameRole gameRole;
    private StartGame startGameResetTime;
    
    public GameObject[] carts;
    int counter;
    void Start()
    {
        carts = new GameObject[16];
        counter = 0;
        
        m_renderer = GetComponent<Renderer>();
        m_renderer.enabled = false;
        m_renderer.material.color = Color.red;
        startGameResetTime = FindObjectOfType<StartGame>();

    }
    void OnMouseDown() { 
        string[] tagNames = { "Cart1", "Cart2", "Cart3", "Cart4", "Cart5", "Cart6", "Cart7", "Cart8",
        "Cart9", "Cart10", "Cart11", "Cart12", "Cart13", "Cart14", "Cart15", "Cart16"};
        foreach (string name in tagNames)
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag(name))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = true;
                }
                carts[counter++] = go;
            }
            

        }
        gameRole = FindObjectOfType<GameRole>();
        gameRole.stepOne = true;
        gameRole.stepTwo = true;
        gameRole.stepThree = true;
        gameRole.stepFour = true;
        gameRole.stepFive = true;
        gameRole.stepSix = true;
        gameRole.stepSeven = true;
        gameRole.stepEight = true;
        startGameResetTime.time = 0;
        startGameResetTime.startTimer = true;
        



        for (int i = 0; i < carts.Length; i++)
        {


            Vector3 temp = carts[i].transform.position;
            int randomIndex = Random.Range(0, carts.Length);
            carts[i].transform.position = carts[randomIndex].transform.position;
            carts[randomIndex].transform.position = temp;

           
        }




    } 
    // Update is called once per frame
    void Update()
    {
        
    }
}
