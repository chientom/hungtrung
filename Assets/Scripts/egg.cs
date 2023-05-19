using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egg : MonoBehaviour
{
    GameController m_gc;
    private void Start()
    {
        m_gc = FindObjectOfType<GameController>();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            m_gc.IncrementScore();
            Destroy(gameObject);
            Debug.Log("Trung va voi ro");
        } 
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("deathzone"))
        {
            m_gc.SetGameoverState(true);
            Destroy(gameObject);
            Debug.Log("Bạn đã hứng sịt");
        }
    }
}
