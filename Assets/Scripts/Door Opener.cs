using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public Animator animator;
    private bool opened = false;

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;

    public void OpenDoor()
    {
        // open the sci-fi door
        if (opened) return;

        animator.SetTrigger("DoorOpen");
        opened = true;

        // play SFX of door opening
        audioSource.PlayOneShot(clip, volume);
    }
}
