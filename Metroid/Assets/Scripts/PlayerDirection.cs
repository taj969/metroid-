using JetBrains.Annotations;
using UnityEngine;

public class PlayerDirection : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite spriteLookingForward;
    public Sprite spriteLookingUpward;

    bool facingRight = true;
    bool lookingUp = false;

    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        if (facingRight && horizontalAxis < 0)
        {
            facingRight = false;
            this.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (!facingRight && horizontalAxis > 0)
        {
            facingRight = true;
            this.transform.localScale = new Vector3(1, 1, 1);
        }

        // Vertical: check if up key is held also added W for convenience
        bool holdingUp = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        if (lookingUp && !holdingUp)
        {
            lookingUp = false;
            spriteRenderer.sprite = spriteLookingForward;
        }
        else if (!lookingUp && holdingUp)
        {
            lookingUp = true;
            spriteRenderer.sprite = spriteLookingUpward;
        }
    }

    public bool isFacingRight()
    {
        return facingRight;
    }

    public bool isLookingUp()
    {
        return lookingUp;
    }
}
