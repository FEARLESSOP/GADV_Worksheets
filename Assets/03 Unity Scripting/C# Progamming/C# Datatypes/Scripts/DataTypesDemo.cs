using UnityEngine;

namespace GADVDataTypes
{

    public class VarExample : MonoBehaviour
    {
        void Start()
        {
            // Inferred as SpriteRenderer
            var sprite = GetComponent<SpriteRenderer>();

            // Inferred as Color
            var spriteColor = sprite.color;

            // Inferred as Vector2            
            var spriteSize = sprite.bounds.size;

            Debug.Log("Sprite Color: " + spriteColor);
            Debug.Log("Sprite Size: " + spriteSize);
        }
    }
}

public class VarMovement : MonoBehaviour
{
    private void Update()
    {
        var speed = 5.0f; // Inferred as float
        var direction = new Vector3(1, 0, 0); // Inferred as Vector3

        transform.position += direction * speed * Time.deltaTime;

        // speed = "fast"; 
    }
}
