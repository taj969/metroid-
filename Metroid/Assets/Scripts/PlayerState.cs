using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public GameObject Standing;
    public GameObject Morphed;

    bool isStanding = true;  // Start in Standing state

    // Update is called once per frame
    void Update()
    {
        // Check if player is standing and presses S or Down Arrow to morph
        if (isStanding && (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)))
        {
            Standing.SetActive(false);
            Morphed.SetActive(true);
            isStanding = false;
        }
        // Check if player is morphed and presses A or Up Arrow to return to standing
        else if (!isStanding && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            Standing.SetActive(true);
            Morphed.SetActive(false);
            isStanding = true;
        }
    }
}
