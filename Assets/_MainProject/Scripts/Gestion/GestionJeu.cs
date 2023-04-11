using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GestionJeu : MonoBehaviour
{

    //SCRIPT POUR LE LAB#3

    //Attributs

    [SerializeField] private TMP_Text _txtAccrochage = default;
    [SerializeField] private TMP_Text _txtTemps = default;
    [SerializeField] private GameObject _menuPause = default;
    private int _pointage;
    private bool _enPause = false;


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
        _txtAccrochage.text = "Accrochages : " + _pointage;
        Instruction();
    }

    private void Update()
    {
        _txtTemps.text = "Temps : " + Time.time.ToString("f2");
        GestionPause();
    }


    private static void Instruction()
    {
        //Instructions du jeu

        Debug.Log("Course � obstacles");
        Debug.Log("Atteindre le sphinx le plus rapidement possible");
        Debug.Log("Chaque obstacle touch� entra�nera une p�nalit�");
    }


    private void GestionPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_enPause)
        {
            _menuPause.SetActive(true);
            Time.timeScale = 0;
            _enPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _enPause)
        {
            EnleverPause();
        }
    }

    //M�thodes publiques

    public void AugmenterPointage()
    {
        _pointage++;
        _txtAccrochage.text = "Accrochages : " + _pointage.ToString();
    }


    public int GetPointage()
    {
        return _pointage;
    }


    public void EnleverPause()
    {
        _menuPause.SetActive(false);
        Time.timeScale = 1;
        _enPause = false;
    }

    //� FAIRE 
    //M�THODE POUR AFFICHER LE POINTAGE DU PREMIER NIVEAU
    //M�THODE POUR AFFICHER LE TEMPS DU NIVEAU 1
    //M�THODE POUR RETOUR AU MENU PRINCIPAL � PARTIR DU MENU DE PAUSE ???
    //Le UI pour l'�cran de fin avec temps et pointage


}
