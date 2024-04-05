using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleHandler : MonoBehaviour
{
    public GameObject basePlate;
    
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            basePlate.GetComponent<Rigidbody>().isKinematic = false;
            
        }
    }

}
