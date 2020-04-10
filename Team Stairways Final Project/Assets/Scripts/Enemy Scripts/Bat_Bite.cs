using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Bat_Bite : MonoBehaviour
{
    AudioSource chomp;


    // Start is called before the first frame update
    void Start()
    {
        chomp = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Bite();   //bite animation
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            chomp.Play();
            PlayerStats.playerHealth--;  
        }
    }


    /// <summary>
    /// This is the animation function
    /// </summary>
    void Bite()
    {

    }
}
