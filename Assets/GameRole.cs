using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
public class GameRole : MonoBehaviour
{
    public List<string> primeNumbers;
    public int[] results;
    public int[] score;

    string carte1, carte2;
    public bool stepOne = true;
    public bool stepTwo = true;
    public bool stepThree = true;
    public bool stepFour = true;
    public bool stepFive = true;
    public bool stepSix = true;
    public bool stepSeven = true;
    public bool stepEight = true;
    private StartGame startGame;
    private ReStartGame newGame;

    string[] tagNames; 

    void Start()
    {
        primeNumbers = new List<string>();
        score = new int[1];
        results = new int[2];
        results[0] = 20;
        results[1] = 50;
    }

    // Update is called once per frame
    void Update()
    {


        if (primeNumbers.Contains("Cart15") && primeNumbers.Contains("Cart7") & stepOne)
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

            score[0] = score[0] + 10;
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Board"))
            {
                TextMeshPro renderer = go.GetComponent<TextMeshPro>();
                if (renderer != null)
                {
                    renderer.text = "Your current point is:" + score[0] + "/80";
                }
            }
            stepOne = false;
        }

        if (primeNumbers.Contains("Cart8") && primeNumbers.Contains("Cart16") & stepTwo)
        {
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

            score[0] = score[0] + 10;
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Board"))
            {
                TextMeshPro renderer = go.GetComponent<TextMeshPro>();
                if (renderer != null)
                {
                    renderer.text = "Your current point is:" + score[0] + "/80";
                }
            }
            stepTwo = false;
        }


        if (primeNumbers.Contains("Cart1") && primeNumbers.Contains("Cart9") & stepThree)
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart9"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Cart1"))
            {
                Renderer renderer = go.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = false;
                }
            }

            score[0] = score[0] + 10;
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Board"))
            {
                TextMeshPro renderer = go.GetComponent<TextMeshPro>();
                if (renderer != null)
                {
                    renderer.text = "Your current point is:" + score[0] + "/80";
                }
            }
            stepThree = false;
        }



        if (primeNumbers.Contains("Cart2") && primeNumbers.Contains("Cart10") & stepFour)
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

            score[0] = score[0] + 10;
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Board"))
            {
                TextMeshPro renderer = go.GetComponent<TextMeshPro>();
                if (renderer != null)
                {
                    renderer.text = "Your current point is:" + score[0] + "/80";
                }
            }
            stepFour = false;
        }




        if (primeNumbers.Contains("Cart3") && primeNumbers.Contains("Cart11") & stepFive)
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
            score[0] = score[0] + 10;
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Board"))
            {
                TextMeshPro renderer = go.GetComponent<TextMeshPro>();
                if (renderer != null)
                {
                    renderer.text = "Your current point is:" + score[0] + "/80";
                }
            }
            stepFive = false;
        }


        if (primeNumbers.Contains("Cart4") && primeNumbers.Contains("Cart12") & stepSix)
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

            score[0] = score[0] + 10;
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Board"))
            {
                TextMeshPro renderer = go.GetComponent<TextMeshPro>();
                if (renderer != null)
                {
                    renderer.text = "Your current point is:" + score[0] + "/80";
                }
            }
            stepSix = false;
        }

        if (primeNumbers.Contains("Cart5") && primeNumbers.Contains("Cart13") & stepSeven)
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

            score[0] = score[0] + 10;
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Board"))
            {
                TextMeshPro renderer = go.GetComponent<TextMeshPro>();
                if (renderer != null)
                {
                    renderer.text = "Your current point is:" + score[0] + "/80";
                }
            }
            stepSeven = false;
        }

        if (primeNumbers.Contains("Cart6") && primeNumbers.Contains("Cart14") & stepEight)
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

            score[0] = score[0] + 10;
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Board"))
            {
                TextMeshPro renderer = go.GetComponent<TextMeshPro>();
                if (renderer != null)
                {
                    renderer.text = "Your current point is:" + score[0] + "/80";
                }
            }
            stepEight = false;
        }

        else if (primeNumbers.ToArray().Length == 2)
        {



            GameObject target = GameObject.FindWithTag(primeNumbers.ElementAt(0));
            target.transform.localRotation *= Quaternion.Euler(0, 180, 0);
            target = GameObject.FindWithTag(primeNumbers.ElementAt(1));
            target.transform.localRotation *= Quaternion.Euler(0, 180, 0);
            primeNumbers.Clear();



        }
        if (!stepOne && !stepTwo && !stepThree && !stepFour && !stepFive && !stepSix && !stepSeven && !stepEight) {
            startGame = FindObjectOfType<StartGame>();
            startGame.startTimer = false;
            ShowMenu();
        }


    }
    void ShowMenu() {

        newGame = FindObjectOfType<ReStartGame>();
        newGame.m_renderer.enabled = true;
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("NewGameBoard"))
        {
            Renderer renderer = go.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.enabled = true;
            }
        }

    }


}
