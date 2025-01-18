using UnityEngine;

public class DestroyOnTime : MonoBehaviour
{

    public float destroyTime;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, destroyTime);
    }

  
}
