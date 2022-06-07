using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("x"))
        {
            Escap();
        }
    }
 
    void Escap() {
        SceneManager.LoadScene("MainMenu");
    }
}
