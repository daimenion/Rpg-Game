using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isattack = false;
    public Animator animation;
    public GameObject fireball;
    public GameObject spawnpoint;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isattack = true;
            animation.Play("attack");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            isattack = true;
            Instantiate(fireball, spawnpoint.transform.position, spawnpoint.transform.rotation);
        }
    }
}
