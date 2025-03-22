using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSnake : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private Vector2 direction;
    public int health = 1;
    [SerializeField] private ScoreManager scoreManager;

    private void Start()
    {
        ValidateMovement(); 
    }

    private void Update()
    {
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
    private void CheckMovement(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            scoreManager.UpdateScore();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Wall"))
        {
            health = 0;
            Debug.Log("Game Over");
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 inputDirection = context.ReadValue<Vector2>();

        if (inputDirection == Vector2.up && direction != Vector2.down) direction = Vector2.up;
        else if (inputDirection == Vector2.down && direction != Vector2.up) direction = Vector2.down;
        else if (inputDirection == Vector2.left && direction != Vector2.right) direction = Vector2.left;
        else if (inputDirection == Vector2.right && direction != Vector2.left) direction = Vector2.right;
    }

    public void OnTriggerEnter(Collider other)
    {
        CheckMovement(other);
    }
}
