using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //game over canvas object
    [Header("Game Over UI Object")]
    public GameObject gameOverCanvas;


    [Header("Game Over UI Object")]
    public GameObject gameOverCanvas;
    
    //hexagon game object  
    [Header("Shape Object")]
    public GameObject[] shapePrefabs;
    //spawn rate for how many objects are spawned
    [Header("Defualt Spawn Delay Time")]
    public float spawnDelay = 2f;
    [Header("Default Spawn Time")]
    public float spwanTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.SetActive(false);
        InvokeRepeating("Spawn", spawnDelay, spwanTime);
    }

    // Update is called once per frame
    void Spawn()
    {
        int randomInt = Random.Range(0, shapePrefabs.Length);
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }
    public void GameOver()
    {
        CancelInvoke("Spawn");
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
  
  
}

