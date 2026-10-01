using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPTmanager : MonoBehaviour

{
    public string[] jugadas = { "roca", "papel", "tijera" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            CheckResult("roca");
        }
        else if(Input.GetKeyDown(KeyCode.P))
        {
            CheckResult("papel");
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            CheckResult("tijera");
        }
        void CheckResult(string jugada)
        {
            string jugadaContraincatne = jugadas[Random.Range(0, 3)];
            if(jugada == "roca")
            {
                if(jugadaContraincatne == "roca")
                {
                    Debug.Log("Empate LOL");
                }
                else if(jugadaContraincatne == "papel")
                {
                    Debug.Log("Perdiste Pete");
                }
                else if (jugadaContraincatne == "tijera")
                {
                    Debug.Log("WTF ganaste");
                }
            }
            else if (jugada == "papel")
            {
                if (jugadaContraincatne == "roca")
                {
                    Debug.Log("WTF ganaste");
                }
                else if (jugadaContraincatne == "papel")
                {
                    Debug.Log("Empate LOL");
                }
                else if (jugadaContraincatne == "tijera")
                {
                    Debug.Log("Perdiste Pete");
                }
            }
            else if (jugada == "tijera")
            {
                if (jugadaContraincatne == "roca")
                {
                    Debug.Log("Perdiste Pete");
                }
                else if (jugadaContraincatne == "papel")
                {
                    Debug.Log("WTF ganaste");
                }
                else if (jugadaContraincatne == "tijera")
                {
                    Debug.Log("Empate LOL");
                }
            }
        }
    }
}
