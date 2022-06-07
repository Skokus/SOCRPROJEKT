using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
 
public class RestartScene : MonoBehaviour
{
    void Start()
    {
        Debug.Log("RestartScene");
    }

    void Update()
    {
        if (Input.GetKey("r")) {
            Restart();
        }
    }
 
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}