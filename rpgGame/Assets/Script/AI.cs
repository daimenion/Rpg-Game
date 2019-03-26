using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AI : MonoBehaviour
{
    public float maxhealth;
        float currenthealth;
    public Slider healthbar;
    Player playercript;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth;
        healthbar.maxValue = maxhealth;
        healthbar.minValue = 0;
        playercript = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = currenthealth;
        if (currenthealth <= 0) {
            Destroy(this.gameObject);
        }
    }
    public void takeDamage(float dmg) {
        currenthealth -= dmg;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword") {
            if (playercript.isattack)
            {
                takeDamage(5);
                playercript.isattack = false;
            }
        }
        if (other.gameObject.tag == "Fire")
        {
            takeDamage(20);
            playercript.isattack = false;
        }
    }

}
