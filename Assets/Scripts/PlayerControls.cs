using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Defuault Movement Speed")]
    //movement speed
    public float moveSpeed = 600f;
    //movement float
    float movement = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //game running at a playing state
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //movement equals to horizontal
        //axis movement (Left or Right)
        movement = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        //Object transformation rotates around an object using the settings.
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        //game is at a stopping state
        Time.timeScale = 0;
        //GameObject.Find("GameController").GetComponent<GameController>().GameOver();

    }
}
