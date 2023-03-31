using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePiegee : MonoBehaviour
{
    // Attributs
    private bool _estActive = false;

    //Modifier pour pouvoir inclure + d'un objet dans zonePiegee

    [SerializeField] private List<GameObject> _listesPieges = new List<GameObject>();


    //Un seul objet dans ma zonePiegee
    //[SerializeField] private GameObject _piege = default;

    private Rigidbody _rb;
    [SerializeField] private float _intensiteForce = 500;
    private List<Rigidbody> _ListeRb = new List<Rigidbody>();

    private void Start()
    {
        foreach (var piege in _listesPieges)
        {
            _ListeRb.Add(piege.GetComponent<Rigidbody>());
        }


        //Un seul objet dans ma zonePiege
        //_rb = _piege.GetComponent<Rigidbody>();
        //_rb.useGravity = false;
    }

    //Zone de déclenchement pour le piège
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_estActive)
        {
            foreach (var rb in _ListeRb)
            {
                Debug.Log("Activer le piege !!!");
                rb.useGravity = true;
                rb.AddForce(Vector3.down * _intensiteForce);
            }
            _estActive = true;
        }




    }
}
