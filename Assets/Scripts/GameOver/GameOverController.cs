﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public void irAMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}