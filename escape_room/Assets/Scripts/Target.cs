using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float TargetMovementRange = 10f;

    private float startX;
    private int direction = 1;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        // Move left and right
        transform.position += Vector3.right * direction * speed * Time.deltaTime;

        // Check bounds and reverse direction if needed
        if (Mathf.Abs(transform.position.x - transform.parent.position.x) >= TargetMovementRange)
        {
            direction *= -1;
        }
    }
}
