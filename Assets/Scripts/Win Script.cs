using UnityEngine;
using System.Collections;
public class WinScript : MonoBehaviour
{
    public GameObject effects;
    private Canvas canvas;

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvas = GetComponent<Canvas>();
        effects = GameObject.Find("Particle System");
        effects.SetActive(false);
        canvas.enabled = false;
    }

    public void Win() {
        canvas.enabled = true;
        effects.SetActive(true);

        // play SFX of win celebration
        audioSource.PlayOneShot(clip, volume);
    }
}
