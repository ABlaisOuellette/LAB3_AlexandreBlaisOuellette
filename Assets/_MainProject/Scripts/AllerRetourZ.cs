using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllerRetourZ : MonoBehaviour
{
    //Attributs
    //Mettre un serializeField pour la vitesse de d�placement

    [SerializeField] private float vitesseDeplacement = 1f;

    //Point de d�part et arriv�e

    private Vector3 pointDepart;
    private Vector3 pointArrivee;


    // Start is called before the first frame update
    void Start()
    {
        pointDepart = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pointArrivee = pointDepart + new Vector3(0, 0, -11);
        float temps = Mathf.PingPong(Time.time * vitesseDeplacement, 1);
        transform.position = Vector3.Lerp(pointDepart, pointArrivee, temps);
    }
}
