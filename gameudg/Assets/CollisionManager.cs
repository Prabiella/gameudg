using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public float pushForce = 10f; // Magnitud de la fuerza a aplicar
    public float mass = 1f; // Masa del objeto

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.GetComponent<Rigidbody2D>(); // Obtener el Rigidbody2D del objeto que colisionó
        if (rb != null)
        {
            Vector2 direction = (collision.transform.position - transform.position).normalized; // Dirección desde el objeto actual al objeto que colisionó
            rb.AddForce(direction * pushForce, ForceMode2D.Impulse); // Aplicar una fuerza en la dirección opuesta a la colisión
        }
    }
}