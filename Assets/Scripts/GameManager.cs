using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerSnake Player;
    public GameObject ComidaPrefab;

    [SerializeField] private Vector2 limites;
    [SerializeField] private int MaxScore;

    private void Start()
    {
        GenerarComida();
    }
    public void GenerarComida()
    {
        float x = Random.Range(-limites.x, limites.x);
        float y = Random.Range(-limites.y, limites.y);

        Instantiate(ComidaPrefab, new Vector2(x, y), Quaternion.identity);
    }
}
