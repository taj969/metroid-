using UnityEngine;

public class PlayerRun : MonoBehaviour
{

    Rigidbody rigid;
    public float moveSpeed = 5;


    void Awake()
    {
        rigid = this.GetComponent<Rigidbody>();
    }


    void Update()
    {
        Vector3 newVelocity = rigid.linearVelocity;
        newVelocity.x = Input.GetAxis("Horizontal") * moveSpeed;




        rigid.linearVelocity = newVelocity;

    }



}
