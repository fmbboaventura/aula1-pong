using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 8;
    private Rigidbody2D rb;

    public int tipo = 1;

    private string eixo;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        eixo = (tipo == 1) ? "Vertical1" : "Vertical2";
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, Input.GetAxisRaw(eixo) * velocidade);
    }
}
