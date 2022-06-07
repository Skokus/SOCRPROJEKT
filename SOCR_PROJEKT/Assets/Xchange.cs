using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Xchange : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Escap();
        }
    }

    void Escap()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
