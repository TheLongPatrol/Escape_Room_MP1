using UnityEngine;
using System.Collections;
public class WinScript : MonoBehaviour
{
    public GameObject effects;
    private Canvas canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvas = GetComponent<Canvas>();
        effects = GameObject.Find("Particle System");
        effects.SetActive(false);
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Win() {
        canvas.enabled = true;
        effects.SetActive(true);
    }
}
