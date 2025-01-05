using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int moedasNaFase;
    public AudioSource somDaMoeda;
    public string proximaFase;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReiniciarJogo();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SairDoJogo();
        }
    }

    public void DescontarMoedas()
    {
        moedasNaFase -= 1;
        somDaMoeda.Play();

        if(moedasNaFase <= 0)
        {
            SceneManager.LoadScene(proximaFase);
        }
    }

    public void ReiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReiniciarJogo()
    {
        SceneManager.LoadScene("Fase 1");
    }

    public void SairDoJogo()
    {
        Debug.Log("Jogo fechado");
        Application.Quit();
    }
}
