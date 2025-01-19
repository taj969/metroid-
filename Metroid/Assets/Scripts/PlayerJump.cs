using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    Rigidbody rigid;
    Collider col;
    public float jumpPower = 12;

    void Awake()
    {
        rigid = this.GetComponentInParent<Rigidbody>();
        col = this.GetComponent<Collider>();
    }


    void Update()
    {
        Vector3 newVelocity = rigid.linearVelocity;
        
        if (Input.GetKeyDown(KeyCode.Z) || (Input.GetKeyDown(KeyCode.Space) && IsGrounded()))
        {
            newVelocity.y = jumpPower;
        }




        rigid.linearVelocity = newVelocity;

    }


    bool IsGrounded()
    {


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
