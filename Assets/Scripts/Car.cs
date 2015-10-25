using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
    public Color color;
    public float combustibil;
    public float VitezaMaxima;
    public float greutatea;
    public float inaltimea;
    public float pret;
    public float CapacitateaBateriei;
    public int Usi;
    private float viteza = 0.0f ;

	// Use this for initialization
	void Deplasare () {
        transform.position = transform.position + Vector3.forward * Time.deltaTime*viteza;
	}
	void Accelereaza () {
        viteza = viteza + 0.1f; 
    }


	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            Deplasare();
        }
        if (Input.GetKey(KeyCode.W))
        {
            Accelereaza();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            viteza = 0.0f;
        }
	}
}
