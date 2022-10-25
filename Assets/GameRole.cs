using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRole : MonoBehaviour
{
    public int[] results;

    void Start()
    {
        results = new int[2];
    }

    // Update is called once per frame
    void Update()
    {
        if (results[0]==8 && results[1] == 16) {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart16"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart8"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
        }
        if (results[0] == 15 && results[1] == 7)
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart7"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart15"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
        }

        if (results[0] == 9 && results[1] == 1)
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart1"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart9"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
        }
        if (results[0] == 10 && results[1] == 2)
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart2"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart10"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
        }
        if (results[0] == 11 && results[1] == 3)
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart3"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart11"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
        }
        if (results[0] == 12 && results[1] == 4)
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart4"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart12"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
        }
        if (results[0] == 13 && results[1] == 5)
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart5"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart13"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
        }
        if (results[0] == 14 && results[1] == 6)
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart6"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart14"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
        }
    }
}
