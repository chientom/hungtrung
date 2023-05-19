using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ro : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    float xDirection;
    void Start()
    {   
        
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");

        float moveStep = moveSpeed * xDirection * Time.deltaTime;
       

        if ((transform.position.x <= -8.5f && xDirection <0 ) || (transform.position.x >= 8.5f && xDirection >0))
            return;

        transform.position += new Vector3(moveStep, 0, 0);
    }
}
