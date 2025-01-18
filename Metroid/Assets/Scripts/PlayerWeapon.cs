using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    PlayerDirection playerDirection;

    public GameObject bulletPrefab;
    public Transform firingPositionForward;
    public Transform firingPositionUpward;
    public float firingSpeed = 10f;

    void Awake()
    {
        playerDirection = this.GetComponentInParent<PlayerDirection>(); // Ensure this is accessing the Player's direction
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.X))
        {
            GameObject bulletInstance = GameObject.Instantiate(bulletPrefab);

            if (playerDirection.isLookingUp()) // Check if player is looking up
            {
                bulletInstance.transform.position = firingPositionUpward.position;
                bulletInstance.GetComponent<Rigidbody>().velocity = Vector3.up * firingSpeed;
            }
            else
            {
                bulletInstance.transform.position = firingPositionForward.position;

                if (playerDirection.isFacingRight()) // Determine shooting direction based on facing right
                {
                    bulletInstance.GetComponent<Rigidbody>().velocity = Vector3.right * firingSpeed;
                }
                else
                {
                    bulletInstance.GetComponent<Rigidbody>().velocity = Vector3.left * firingSpeed;
                }
            }
        }
    }
}
