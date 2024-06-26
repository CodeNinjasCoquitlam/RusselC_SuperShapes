using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
  
    [Header("Rigidbody Object")]
    public Rigidbody2D rb;
    //rigidbody for object
    [Header("Defualt Shrinking Speed")]
    //shrinking speed
    public float shrinkSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //rotation of the rigidbody at a random range
        rb.rotation = Random.Range(0f, 360f);
        //local scale for the hexagon equals one for all axis times ten
        transform .localScale = Vector3.one * 10f;
        
    
    
    
    }

    // Update is called once per frame
    void Update()
    {
        //local scale equals for shrinking multiplied by axis is less or equals to .05
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if (transform.localScale.x <= .05f)
        {
            //destroy object
            Destroy(gameObject);
            Score.score++;
        }
    }  
   
}
