using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSnake : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private Vector2 direction;
    private int health = 1;
    //public ScoreManager scoreManager;

    private void Update()
    {
        CheckMovement();
        Movement();
    }
    private void ValidateMovement()
    {
        if (direction == Vector2.zero)
            direction = Vector2.right;
    }
    public void Movement()
    {
        transform.Translate(direction * velocity * Time.deltaTime);
    }
    private void CheckMovement()
    {
        if (Input.GetKeyDown(KeyCode.W)) direction = Vector2.up;
        if (Input.GetKeyDown(KeyCode.S)) direction = Vector2.down;
        if (Input.GetKeyDown(KeyCode.A)) direction = Vector2.left;
        if (Input.GetKeyDown(KeyCode.D)) direction = Vector2.right;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food"))
        {
            //scoreManager.UpdateScore();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Walls"))
        {
            health = 0;
            Debug.Log("Game Over");
        }
    }
}
