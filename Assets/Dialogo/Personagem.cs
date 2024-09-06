using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (fileName="NovoPersonagem" , menuName="Dialogo/Personagem")]
public class Personagem : ScriptableObject
{
    public string Nome;
    public Sprite[] expressoes;
}
