using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{

    string asCopas = "Ás de Copas ";
    string asEspadas = "Ás de Espadas ";
    string asOuros = "Ás de Ouros ";
    string asPaus = "Ás de Paus ";
    string reiCopas = "Rei de Copas ";
    string reiPaus = "Rei de Paus";

    string sorteioCartas = "";



    // Start is called before the first frame update
    void Start()
    {
        IniciarJogo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sortearCart();

        }
    }

    void IniciarJogo() {
        Debug.Log("Carregue no espaco para sair uma carta!");

    }

    void sortearCart() {
        int cartas = Random.Range(0, 5);
        if (cartas == 0)
        {
            sorteioCartas += asCopas;
        }
        else if (cartas == 1) {
            sorteioCartas += asEspadas;
        }
        else if (cartas == 2)
        {
            sorteioCartas += asOuros;
        }
        else if (cartas == 3)
        {
            sorteioCartas += asPaus;
        }
        else if (cartas == 4)
        {
            sorteioCartas += reiCopas;
        }
        else if (cartas == 5)
        {
            sorteioCartas += reiPaus;
        }
        Debug.Log(" || " + sorteioCartas + " || ");
    }
}
