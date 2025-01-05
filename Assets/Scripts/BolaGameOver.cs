using UnityEngine;

public class BolaGameOver : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindFirstObjectByType<GameManager>().ReiniciarPartida();
        }
    }

}
