using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ControleDoJogador : MonoBehaviour
{

    public float velocidadeDoJogador;
    public Rigidbody oRigidBody;
    private float movimentoX;
    private float movimentoZ;

    void Start()
    {

    }

    void Update()
    {
        MovimentarBola();
    }

    private void MovimentarBola()
    {
        movimentoX = Input.GetAxis("Horizontal") * velocidadeDoJogador;
        movimentoZ = Input.GetAxis("Vertical") * velocidadeDoJogador;
        oRigidBody.AddForce(movimentoX, 0f, movimentoZ);
    }
}
