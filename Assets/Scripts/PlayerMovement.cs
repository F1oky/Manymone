
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private bool isMoving;
    private Vector2 input;
    private Vector3 targetPos;

    void Start()
    {
        targetPos = transform.position;
    }

    void Update()
    {
        if (isMoving) return;

        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        if (input != Vector2.zero)
        {
            input.y = (input.x != 0) ? 0 : input.y; // interdit diagonale
            var target = transform.position + new Vector3(input.x, input.y, 0);
            StartCoroutine(Move(target));
        }
    }

    System.Collections.IEnumerator Move(Vector3 target)
    {
        isMoving = true;
        while ((target - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = target;
        isMoving = false;
    }
}
