using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Arrivee : MonoBehaviour
{
    //Attributs
    [SerializeField] private TMP_Text _txtTempsTotal = default;
    [SerializeField] private TMP_Text _txtPointage = default;
    [SerializeField] private TMP_Text _txtCollision = default;
    private GestionJeu _gestionJeu;
    private Player _player;

    //trouver notre objet de type Gestion jeu puis passer la variable à la classe Arrivee
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {        
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        if (indexScene == 3)
        {
            if (collision.gameObject.tag == "Player")
            {
                //Pour le nombre total de collision                
                int erreur = _gestionJeu.GetPointage();
                //_txtCollision.text = "Collision(s): " + erreur.ToString();
                

                //Pour changer la couleur de la capsule 
                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                
                Debug.Log("La partie est terminée !!!" + "\nVotre temps est de: " + Time.time);
                Debug.Log("Vous avez accroché " + erreur + " obstacles");

                //Time.time nous donne le temps de la partie
                string tempsSansAccrochage = Time.time.ToString("f2");
                //_txtTempsTotal.text = "Temps total: " + tempsSansAccrochage;

                //Ici c'est pour avoir le temps total plus le nombre d'accrochage(s)
                float total = Time.time + erreur;
                //_txtPointage.text = "Temps final: " + total.ToString("f2");

                Debug.Log(" Votre temps final est de: " + total);                

                //Charger la scene fin
                SceneManager.LoadScene(indexScene + 1);

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
