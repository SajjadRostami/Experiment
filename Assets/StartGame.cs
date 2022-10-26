using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StartGame : MonoBehaviour
{
    private Renderer m_renderer;
    public bool startTimer;
    public float time;
    void Start()
    {
        startTimer = false;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer) {
            time += Time.deltaTime;
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("Timer"))
            {
                TextMeshPro renderer = go.GetComponent<TextMeshPro>();
                if (renderer != null)
                {
                    renderer.text = "Time:" + Mathf.FloorToInt(time % 60);
                }
            }
        }
        
    }
    void OnMouseDown()
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("StartBoard"))
        {
            TextMeshPro renderer = go.GetComponent<TextMeshPro>();
            
            if (renderer != null)
            {
                renderer.enabled = false;
            }
        }
        m_renderer = GetComponent<Renderer>();
        m_renderer.enabled = false;
        transform.position = new Vector3(10, 0, 5);
        startTimer = true;

    }

   
}
