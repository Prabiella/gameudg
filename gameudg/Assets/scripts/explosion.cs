using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{

    private Animator anim;
    private bool isExploding = false;


    private void Awake()
    {
       anim = GetComponentInChildren<Animator>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (anim != null)
        {
            anim.SetTrigger("explosion");
        }
        else
        {
            Debug.LogWarning("Animator no encontrado. Asegúrate de tener un Animator adjunto al objeto o a sus hijos.");
        }
    }


    IEnumerator ReturnToFlyAnimation()
    {
        yield return new WaitForSeconds(2f); // Espera 2 segundos

        if (anim != null)
        {
            // Activa la animación de flyrocket
            anim.SetTrigger("flyrocket");
            isExploding = false; // Reinicia el indicador de explosión
        }
    }





}
