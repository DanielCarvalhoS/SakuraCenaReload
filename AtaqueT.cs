using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class AtaqueT : MonoBehaviour
{
    public Transform magiaSpawnPoint;
    public GameObject MagiaCooler;
    [SerializeField] Rigidbody rb;
    public float MagiaSpeed = 5;
    // Start is called before the first frame update

    public GameObject SakuraNormal;
    public GameObject SakuraTransform;
    public Sakura personagem = new Sakura(100, 5, false, 2);
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Replace(SakuraNormal, SakuraTransform);
            personagem.Transformar = true;
            Debug.Log("PersonagemTransformar");
     
        }
        if (Input.GetKeyDown(KeyCode.E) && personagem.Transformar == false)
        {
            Debug.Log("NaoTransformou");
        }
        else if (Input.GetKeyDown(KeyCode.E) && personagem.Transformar == true)
        {           
                var magia = Instantiate(MagiaCooler, magiaSpawnPoint.position, magiaSpawnPoint.rotation);
                rb.velocity = magiaSpawnPoint.forward * MagiaSpeed;
                
            
        }

  
    }
    void Replace(GameObject obj1, GameObject obj2)
    {
        Instantiate(obj2, obj1.transform.position, Quaternion.identity);
        Destroy(obj1);
    }

}

