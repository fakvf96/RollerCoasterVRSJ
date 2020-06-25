using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlaySnow()
    {
        SceneManager.LoadScene("RollerCoasterSnow");
    }

    public void PlayFlorest()
    {
        SceneManager.LoadScene("Florest");
    }

    public void PlayIsland()
    {
        SceneManager.LoadScene("iSLAND");
    }
}