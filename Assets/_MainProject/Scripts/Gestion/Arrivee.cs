using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrivee : MonoBehaviour
{
    //Attributs

    private GestionJeu _gestionJeu;
    private Player _player;

    //fonction pour la fin du jeu + affich� en console victoire et score ...fin de partie

    //trouver notre objet de type Gestion jeu puis passer la variable � la classe Arrivee
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        int indexScene = SceneManager.GetActiveScene().buildIndex;
        if (indexScene == 2)
        {
            if (collision.gameObject.tag == "Player")
            {
                int erreur = _gestionJeu.GetPointage();

                //changer la couleur de la capsule 
                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                Debug.Log("La partie est termin�e !!!" + "\nVotre temps est de: " + Time.time);
                Debug.Log("Vous avez accroch� " + _gestionJeu.GetPointage() + " obstacles");

                //Time.time nous donne le temps de la partie
                float total = Time.time + erreur;
                Debug.Log(" Temps final: " + total);

                //Rendre le joueur inactif pour la fin de partie
                _player.FinPartie();
            }
        }
        else
        {
            //Charger la scene suivante
            SceneManager.LoadScene(indexScene + 1);

        }


    }
}
