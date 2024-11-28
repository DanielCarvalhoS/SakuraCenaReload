using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class BossMove : MonoBehaviour
{
    public GameObject Boo;
    public GameObject SakuraNormal;
    public AtaqueT AtaqueT;
    public GameObject SakuraTransform;
    public Boss chefe = new Boss(60, 1f, 1);
    public Transform Sakura1;
    public float RotateSpeed = 5f;
    void Start()
    {
        AtaqueT = GameObject.FindGameObjectWithTag("Sakura").GetComponent<AtaqueT>();
    }

    // Update is called once per frame
    void Update()
    {
        FindSakura();

        if (SakuraNormal != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, SakuraNormal.transform.position, Time.deltaTime * 7f);
            LookAtPlayer();
        }
    }
    private void LookAtPlayer()
    {
        Vector3 direction = SakuraNormal.transform.position - transform.position; // Direção do jogador
        direction.y = 0;  // Para evitar rotação no eixo Y (vertical)
        Quaternion rotation = Quaternion.LookRotation(direction); // Calcula a rotação para olhar na direção do jogador
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * RotateSpeed); // Suaviza a rotação
    }
    private void FindSakura()
    {

        if (SakuraNormal == null)
        {
            SakuraNormal = GameObject.FindGameObjectWithTag("Sakura");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ataque") 
        {
            chefe.Hp(1);
            Debug.Log(chefe.Vida);

            if (chefe.Vida == 0) 
            {
                Destroy(this.gameObject);
            }
        }
    }
}
