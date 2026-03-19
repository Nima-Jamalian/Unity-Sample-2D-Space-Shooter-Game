using UnityEngine;

public class Enemy : MonoBehaviour
{   
    private Rigidbody2D rb;
    [SerializeField] private float speed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Destroy(gameObject, 4f);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (Vector2)transform.up * -1 * speed * Time.fixedDeltaTime);
    }
}
