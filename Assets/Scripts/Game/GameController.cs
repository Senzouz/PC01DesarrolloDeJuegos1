using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public List<GameObject> elementos = new List<GameObject>();
    public List<GameObject> pool = new List<GameObject>();
    private float generationTime = 4.0f;
    public int Score =  0;
    public int vida = 5;
    public Text scoreText;
    public Text vidasText;
    private float startX;
    private float timeElapsed;

    void Start()
    {
        CrearPool();
    }

    void CrearPool()
    {
        for (int i = 0; i < elementos.Count; i++)
        {
            for (int j = 0; j < elementos.Count; j++)
            {
                print(startX);
                GameObject gameO = Instantiate(getNext(), new Vector3(0, 0, 1.0f),Quaternion.identity);
                gameO.SetActive(false);
                pool.Add(gameO);
            }
        }
    }

    GameObject getNext()
    {
        int index = Random.Range(0, elementos.Count);
        return elementos[index];
    }

    public string TextoVidas()
    {
        return "Vidas: " + vida.ToString();
    }


    void PrimerMuerto()
    {
        while (true)
        {
            int index = Random.Range(0, pool.Count);
            if (!pool[index].activeSelf)
            {
                pool[index].SetActive(true);
                pool[index].transform.position = new Vector3(Random.Range(-(Camera.main.aspect * Camera.main.orthographicSize), (Camera.main.aspect * Camera.main.orthographicSize)), 8, 0);
                break;
            }
            else
            {
                index = Random.Range(0, pool.Count);
            }
        }
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        vidasText.text = TextoVidas();
        scoreText.text = Score.ToString();
        if(timeElapsed > generationTime)
        {
            PrimerMuerto();
            timeElapsed = 0;
        }
        if(vida <= 0)
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
}
