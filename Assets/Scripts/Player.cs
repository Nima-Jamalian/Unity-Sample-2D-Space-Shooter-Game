using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    private Rigidbody2D rb;
    private Vector2 direction;
    [SerializeField] private GameObject laserPrefab;

    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
        Animate();
    }

    private void Movement()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        float directionX = Input.GetAxisRaw("Horizontal");
        direction = new Vector3(directionX,directionY,0);
        // Normalize to prevent faster diagonal movement
        direction = direction.normalized;
    }

    void FixedUpdate()
    {
        Vector3 newPosition = rb.position + direction * speed * Time.fixedDeltaTime;

        // Wrap X position
        if(newPosition.x >= GameManager.worldSizeWidth + 0.5f)
        {
            newPosition.x = -GameManager.worldSizeWidth - 0.5f;
        } else if (newPosition.x <= -GameManager.worldSizeWidth - 0.5f)
        {
            newPosition.x = GameManager.worldSizeWidth + 0.5f;
        }

        // Clamp Y position
        newPosition.y = Mathf.Clamp(newPosition.y,-GameManager.worldSizeHeight + 1f,0f);

        rb.MovePosition(newPosition);
    }

    private void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab,transform.position,transform.rotation);
        }
    }

    private void Animate()
    {
        animator.SetFloat("X", direction.x);
    }
}
