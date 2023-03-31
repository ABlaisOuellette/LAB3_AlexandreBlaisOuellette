using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllerRetourZNegatif : MonoBehaviour
{
    //Attributs
    //Mettre un serializeField pour la vitesse de déplacement

    [SerializeField] private float vitesseDeplacement = 1f;

    //Point de départ et arrivée

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
        pointArrivee = pointDepart + new Vector3(0, 0, 14);
        float temps = Mathf.PingPong(Time.time * vitesseDeplacement, 1);
        transform.position = Vector3.Lerp(pointDepart, pointArrivee, temps);
    }
}
