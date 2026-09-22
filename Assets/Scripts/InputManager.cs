using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    PlayerMovement playerMovement;
    [SerializeField] GameObject playerGM;

    void Update()
    {
        
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("holding");
            playerGM.transform.position += new Vector3(5, 0, 0); // Eloigner le j. de la p. par rapport à la longueur du grapping
            ScoringManager.SINGLETON.currentPlayerRotationSpeed = 250;

        }

        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            Debug.Log("released");
            ScoringManager.SINGLETON.currentPlayerRotationSpeed = 0;
            ScoringManager.SINGLETON.playerSpeed = 50;
        }
    }
}
