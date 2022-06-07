using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kolizja : MonoBehaviour
{
    // Start is called before the first frame update
 
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Trap")
        {   
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

