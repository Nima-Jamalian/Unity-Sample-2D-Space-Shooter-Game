using UnityEngine;

public class Background : MonoBehaviour
{
    private Material material;

    [SerializeField] private float speed = 3f;
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        material.mainTextureOffset += new Vector2(0,speed * Time.deltaTime);
    }
}
