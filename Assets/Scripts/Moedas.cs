using UnityEngine;

public class Moedas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FindFirstObjectByType<GameManager>().moedasNaFase += 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            FindFirstObjectByType<GameManager>().DescontarMoedas();
            Destroy(this.gameObject);
        }
    }
}
