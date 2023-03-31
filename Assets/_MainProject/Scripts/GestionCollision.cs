using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    //Attributs

    private GestionJeu _gestionJeu;
    private bool _toucher;

    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _toucher = false;
    }

    //Méthodes privées

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_toucher)
            {
                //mettre le mur de couleur rouge suite à un contact
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                _gestionJeu.AugmenterPointage();
                _toucher = true;
            }
        }
    }
}
