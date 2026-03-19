using Unity.Mathematics;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 5;
    [SerializeField] private GameObject explosionPrefab;
    private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManger").GetComponent<GameManager>();
        Destroy(gameObject,4f);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (Vector2)transform.up * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Instantiate(explosionPrefab,transform.position,quaternion.identity);
            gameManager.IncreaseScore();
            Destroy(gameObject);
        }
    }
}
