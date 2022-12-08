using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class FastTravel : MonoBehaviour
{
    public GameObject wristUI;

    public bool activeWristUI = true;
    // Start is called before the first frame update
    void Start()
    {
        DisplayWristUI();
    }

    public void PauseButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            DisplayWristUI();
        }
    }
    public void DisplayWristUI()
    {
        if (activeWristUI)
        {
            wristUI.SetActive(false);
            activeWristUI = false;
        }
        else if (!activeWristUI)
        {
            wristUI.SetActive(true);
            activeWristUI = true;
        }
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(1);
    }

    public void SwitchScene0()
    {
        SceneManager.LoadScene(0);
    }

    public void SwitchScene2()
    {
        SceneManager.LoadScene(2);
    }

    public void SwitchScene3()
    {
        SceneManager.LoadScene(3);
    }

    public void SwitchScene4()
    {
        SceneManager.LoadScene(4);
    }

}