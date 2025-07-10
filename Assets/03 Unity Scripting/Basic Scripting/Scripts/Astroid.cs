using UnityEngine;

public class AsteroidColourTinter : MonoBehaviour
{
    private Color currentColor = Color.white;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = currentColor;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentColor == Color.white)
            {
                currentColor = Color.blue;
            }
            else
            {
                currentColor = Color.white;
            }

            spriteRenderer.color = currentColor;
        }
    }
}
