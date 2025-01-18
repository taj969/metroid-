using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rigid;
    public float moveSpeed = 5;
    public float jumpPower = 15;

    void Awake()
    {
        rigid = this.GetComponent<Rigidbody>();
    }


    void Update()
    {
        Vector3 newVelocity = rigid.velocity;
        newVelocity.x = Input.GetAxis("Horizontal") * moveSpeed;
        if(Input.GetKeyDown(KeyCode.Z))
        {
            newVelocity.y = jumpPower;
        }




        rigid.velocity = newVelocity;

    }
}
