using UnityEngine;
using System.Collections;
public class DogScript : MonoBehaviour
{
    public Animator animator;
    private float move_speed = 0.5f;
    private bool eat_triggered = false;
    private bool moving = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (eat_triggered) {
            if (moving) {
                if (transform.position.z < 4) {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+(move_speed*Time.deltaTime));  
                } else {
                    moving = false;
                    animator.SetTrigger("StopMoving");
                }
                //Debug.Log(transform.position.z+" "+moving);
            }
        }
    }

    public void DogEats() {
        animator.SetTrigger("Fed");
        eat_triggered = true;
    }

    public void Move() {
        animator.SetTrigger("StartMoving");
        GameObject cake_object = GameObject.Find("Cake");
        cake_object.SetActive(false);
        moving = true;
        
    }
}
