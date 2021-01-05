using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMov movement;
    public GameManager gameManager;
  void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
