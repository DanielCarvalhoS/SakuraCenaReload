using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sakura
{
    public float Move { get; set; }
    public int Vida { get; set; }
    public bool Transformar { get; set; }
    public int Cooldown { get; set; }

    public Sakura(float Move, int Vida, bool Transformar, int Cooldown)
    {
        this.Move = Move;
        this.Vida = Vida;
        this.Transformar = Transformar;
        this.Cooldown = Cooldown;
    }
   
}    


