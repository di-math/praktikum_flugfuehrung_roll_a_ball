using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{

    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)){
            this.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.Q)){
            this.transform.Rotate(Vector3.left * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.E)){
            this.transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
