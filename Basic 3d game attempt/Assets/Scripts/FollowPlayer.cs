using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    // Note that in Unity I have set the camera offset to be x = 0, y = 1 and z = -5
    public Vector3 camera_offset;

    // Update is called once per frame
    void Update()
    {
        // transform.position is the position of the object that this script is linked to, in this case the camera
        // When the update function is called the camera_offset vector is added onto the player's current position, resulting in the camera being slightly above and behind the player.
        transform.position = player.position + camera_offset;
    }
}
