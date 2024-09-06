using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // bliblioteca do TextMeshPro
using UnityEngine.UI; //biblioteca dos componentes de UI

public class ControleDialogo : MonoBehaviour
{
    public TextMeshProUGUI txtPersonagem,txtFalas;
    public Image expressoes;
    public GameObject caixaDeDialogo;
    Falas falaAtual;
    int indice=0;
    Queue <string> filaFalas; //Queue cria uma lista

    public void iniciarFalas(Falas fala){
        caixaDeDialogo.SetActive(true);
        filaFalas = new Queue<string>();
        falaAtual=fala;
        indice=0;
        proximaFala(); //função que ainda vamos criar
    }

    public void proximaFala(){
        if(filaFalas.Count ==0){
            if(indice < falaAtual.Conversas.Length){
                expressoes.sprite=falaAtual.Conversas[indice].personagem.expressoes[falaAtual.Conversas[indice].IdExpressoes];
                expressoes.SetNativeSize();
                txtPersonagem.text=falaAtual.Conversas[indice].personagem.Nome;
                foreach(string textoFalas in falaAtual.Conversas[indice].TextoDasFalas){
                    filaFalas.Enqueue(textoFalas); // Enqueue adiciona o item na lista
                }
                indice++;
            }else{
                caixaDeDialogo.SetActive(false);
                return;
            }
        }
        txtFalas.text=filaFalas.Dequeue(); //Dequeue exibe o elemento da lista e depois remove esse elemento
    }
}
