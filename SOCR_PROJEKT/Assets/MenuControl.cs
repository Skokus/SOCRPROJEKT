using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    [Header("Take a character")]
    public string theCharacter;

    public void ExitButton()
    {
        Application.Quit();
    }
}
