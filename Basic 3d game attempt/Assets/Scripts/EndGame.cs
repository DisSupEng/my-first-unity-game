using UnityEngine;

public class EndGame : MonoBehaviour
{
   public GameManager gameManager;
   
   void OnTriggerEnter(Collider other)
   {
       gameManager.CompleteLevel();
   }
}
