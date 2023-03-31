using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    //Attributs

    private int _pointage;


    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


    // Start is called before the first frame update
    private void Start()
    {
        _pointage = 0;
        Instruction();
    }

    private static void Instruction()
    {
        //Instructions du jeu

        Debug.Log("Course à obstacles");
        Debug.Log("Atteindre le sphinx le plus rapidement possible");
        Debug.Log("Chaque obstacle touché entraînera une pénalité");
    }

    //Méthodes publiques

    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochage: " + _pointage);
    }


    public int GetPointage()
    {
        return _pointage;
    }


}
