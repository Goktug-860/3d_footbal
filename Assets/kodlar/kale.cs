using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter2D (Collider2D other)
    {
           if(other.gameObject.tag == "Respawn")
        {
            transform.position = new Vector3(0,3,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
