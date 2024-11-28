using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss 
{
    public int Vida { get; set; }
    public float Move { get; set; }
    public int Poder { get; set; }
    public Boss(int Vida, float Move, int Poder) 
    {
        this.Vida = Vida;
        this.Move = Move;
        this.Poder = Poder;
    }

    public void Hp(int Dano)
    {
        this.Vida -= Dano;
        if (this.Vida <= 0)
        {
            SceneManager.LoadScene("Vitoria");
        }
    }
}
