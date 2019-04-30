using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement; // <<<<<< ADD THIS.

public class click : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Room");
    }
}
