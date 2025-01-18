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
        if(Input.GetKeyDown(KeyCode.Z) && IsGrounded())
        {
            newVelocity.y = jumpPower;
        }




        rigid.velocity = newVelocity;

    }


    bool IsGrounded()
    {

        Collider col = this.GetComponentInChildren<Collider>();

        Ray ray = new Ray(col.bounds.center, Vector3.down);

        float radius = col.bounds.extents.x - 0.5f;

        float fullDistance = col.bounds.extents.y + 0.5f;


        if (Physics.SphereCast(ray, radius, fullDistance))
        {
            return true;
        }
        else
        {
            return false;
        }




    }









    }
