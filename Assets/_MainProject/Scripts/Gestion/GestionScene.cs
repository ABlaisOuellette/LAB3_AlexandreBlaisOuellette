using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{
    //Attributs

    [SerializeField] private GameObject _menuInstruction = default;
    private bool _menuOuvert = false;

    //Méthodes publiques

    public void Instruction()
    {
        //Affiche les instructions du jeu

        if (!_menuOuvert)
        {
            _menuInstruction.SetActive(true);
            _menuOuvert =true;
        }
    }

    public void ChangerSceneSuivante()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex; // Récupère l'index de la scène en cours
        SceneManager.LoadScene(noScene + 1);
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(0);
    }
}
