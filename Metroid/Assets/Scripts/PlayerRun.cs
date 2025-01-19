using UnityEngine;

public class PlayerRun1 : MonoBehaviour
{

    Rigidbody rigid;
    public float moveSpeed = 5;


    void Awake()
    {
        rigid = this.GetComponent<Rigidbody>();
    }


    void Update()
    {
        Vector3 newVelocity = rigid.velocity;
        newVelocity.x = Input.GetAxis("Horizontal") * moveSpeed;




        rigid.velocity = newVelocity;

    }



}
