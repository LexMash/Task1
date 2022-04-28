using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _movementSpeed;

    private float _verticalMove;
    private float _horizontalMove;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _verticalMove = Input.GetAxis("Vertical") * _movementSpeed * Time.deltaTime;
        _horizontalMove = Input.GetAxis("Horizontal") * _movementSpeed * Time.deltaTime;

        transform.position += new Vector3(_horizontalMove, _verticalMove, 0);
    }
}
