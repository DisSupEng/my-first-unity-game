using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public PlayerMovement movementControls;

    public void OnCollisionEnter(Collision info)
    {
        if(info.collider.tag == "Obstacle")
        {
            // Once the player has hit an object we want to disabled the movement script
            movementControls.enabled = false;

        }
    }
}
