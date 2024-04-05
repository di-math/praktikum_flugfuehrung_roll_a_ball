using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public float speed = 1;
    public float min_sound = 0;
    public float max_sound = 1;
    public bool keyboard = false;
    public TextMeshPro gamestats;

    private Rigidbody rb;
    private int game_points = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(keyboard){
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            
            Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

            rb.AddForce(movement*speed);
        }

    }

    void Update(){
        GetComponent<AudioSource>().volume = (float)Math.Clamp(Vector3.SqrMagnitude(GetComponent<Rigidbody>().velocity)*1.2, min_sound, max_sound);
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Pick Up")){
            other.gameObject.SetActive(false);
            gamestats.text = "Current Points: " + ++game_points;
        }
    }

}
