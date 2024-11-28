using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SakuraTransformada : MonoBehaviour
{
    public Transform magiaSpawnPoint;
    public GameObject MagiaCooler;
    [SerializeField] Rigidbody rb;
    public float MagiaSpeed = 10;
    public Sakura personagem = new Sakura(100, 5, true, 2);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            var magia = Instantiate(MagiaCooler, magiaSpawnPoint.position, magiaSpawnPoint.rotation);
            rb.velocity = magiaSpawnPoint.forward * MagiaSpeed;
        }
    }
}
