using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    public void HomeScene()
    {
        SceneManager.LoadScene("HomeScene");
    }

    public void UserScene()
    {
        SceneManager.LoadScene("UserScene");
    }

    public void AddCourseScene()
    {
        SceneManager.LoadScene("AddCourseScene");
    }
}
