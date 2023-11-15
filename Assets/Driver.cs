using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal");
        float moveAmount = Input.GetAxis("Vertical");
        transform.Rotate(0,0,steerAmount);
        transform.Translate(0,0.1f*moveAmount,0);
    }
}
