using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public void OnCollisionEnter(Collision info)
    {
        if(info.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle");
        }
    }
}
