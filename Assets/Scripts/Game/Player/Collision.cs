using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameController gameController;
    private void OnTriggerEnter2D(Collider2D other)
    {
        string name = other.gameObject.name;
        switch (name)
        {
            case "Candy(Clone)":
                if (gameController.Score % 2 == 0)
                {
                    gameController.Score *= 2;
                }
                else
                {
                    gameController.Score += 5;
                }
                break;
            case "Marshmallow(Clone)":
                if (gameController.Score % 5 == 0)
                {
                    gameController.Score += 30;
                }
                else
                {
                    gameController.Score += 10;
                }
                break;
            case "JellyBean(Clone)":
                if (gameController.Score % 2 == 0)
                {
                    gameController.Score *= 2;
                }
                else
                {
                    gameController.Score += 5;
                }
                break;
            case "Donut(Clone)":
                gameController.Score += 50;
                break;
            case "Cupcake(Clone)":
                break;
        }
        other.gameObject.SetActive(false);
        PlayerPrefs.SetInt("Puntaje", gameController.Score);
    }
}
