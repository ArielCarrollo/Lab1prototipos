using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Atributos p�blicos
    public PlayerSnake Player;
    public GameObject ComidaPrefab;

    // Atributos privados
    [SerializeField] private Vector2 limites;
    [SerializeField] private int MaxScore;

    private void Start()
    {
        GenerarComida();
    }

    // M�todo p�blico: Genera comida aleatoriamente dentro de los l�mites
    public void GenerarComida()
    {
        float x = Random.Range(-limites.x, limites.x);
        float y = Random.Range(-limites.y, limites.y);

        Instantiate(ComidaPrefab, new Vector2(x, y), Quaternion.identity);
    }
}
