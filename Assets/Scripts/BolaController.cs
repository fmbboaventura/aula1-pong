using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public float velocidade = 8;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(velocidade, 0);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player")) {
            float y = (transform.position.y - col.transform.position.y) / col.collider.bounds.size.y;
            Vector2 dir = new Vector2(
                (col.gameObject.name == "Player1") ? 1 : -1, y
            ).normalized;
            rb.velocity = dir * velocidade;
        }

        if (col.gameObject.CompareTag("Gol")) {
            transform.position = new Vector3(0, 0, transform.position.z);
            if (col.gameObject.name == "ParedeEsquerda")
                ScoreManager.SharedInstance.IncrementarScore(2);
            else ScoreManager.SharedInstance.IncrementarScore(1);
        }
    }
}
