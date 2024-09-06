using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (fileName="novaFala", menuName="Dialogo/Falas")]
public class Falas : ScriptableObject
{
    public FalasDosPersonagens[] Conversas;
}

[System.Serializable]
public class FalasDosPersonagens{
    public int IdExpressoes;
    public Personagem personagem;
    [TextArea]
    public string[] TextoDasFalas;
}