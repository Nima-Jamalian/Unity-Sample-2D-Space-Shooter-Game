using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // spriteRenderer = GameObject.Find("Square").GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
