using UnityEngine;

public class Enemy : MonoBehaviour
{  
    private Rigidbody2D rb;
    [SerializeField] private float speed = 3f;
    [SerializeField] private GameObject explosionPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
         rb.MovePosition(rb.position + (Vector2)transform.up * -1 * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")){
            Destroy(collision.gameObject);
            Instantiate(explosionPrefab,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
