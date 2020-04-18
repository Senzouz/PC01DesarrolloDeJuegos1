using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    public GameController gameController;
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.SetActive(false);
        gameController.vida -= 1;
    }
}
