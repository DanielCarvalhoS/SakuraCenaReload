https://drive.google.com/file/d/1OAZSTOOwxYbxo1aYdh1I0BbCGrh04zzB/view?usp=sharing


----------------------------------------------------------------------------------------


```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Missao");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Missao1()
    {
        SceneManager.LoadScene("City");
    }

    public void Retentar()
    {
        SceneManager.LoadScene("LutaBoss");
    }
    public void Menuzin()
    {
        SceneManager.LoadScene("Menu");
    }
}

```
------------------------------------------------------------
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SD
{

    public class PlayerController : MonoBehaviour
    {

        [Header("Player Setting")]
        public bool stopMoverment = false;
        public bool moving { get; set; }
        float m_Horizontal, m_Vertical;
        [HideInInspector]
        public Animator m_Animator;
        private CharacterController characterController;
        private bool playerNearby = false;
        void Awake()
        {
            m_Animator = GetComponent<Animator>();

        }

        private void Update()
        {
            if (playerNearby)
            {
                LoadScenes1();
            }
        }
        void FixedUpdate()
        {
            m_Horizontal = Input.GetAxis(Const.Horizontal);
            m_Vertical = Input.GetAxis(Const.Vetical);

            bool has_H_Input = !Mathf.Approximately(m_Horizontal, 0);
            bool has_V_Input = !Mathf.Approximately(m_Vertical, 0);

            if (!stopMoverment) moving = has_H_Input || has_V_Input;
            else moving = false;

            float inputSpeed = Mathf.Clamp01(Mathf.Abs(m_Horizontal) + Mathf.Abs(m_Vertical));

            m_Animator.SetBool(Const.Moving, moving);
            m_Animator.SetFloat(Const.Speed, inputSpeed);



        }
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                playerNearby = false;  // Marca que o jogador não está mais perto da porta
            }
        }

        // Método para carregar a cena
        private void LoadScene()
        {
                SceneManager.LoadScene("LutaBoss");  // Carrega a cena especificada
        }
                
   
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Boo"))
            {
                playerNearby = true;
                LoadScenes1();
            }
            
            void LoadScenes()
            {
               SceneManager.LoadScene("LutaBoss");
            }
            if (other.CompareTag("paredetp"))
                {
                    LoadScenes();
                }
                    
            void LoadScenes2()
            {
                SceneManager.LoadScene("City");
            }
                if (other.CompareTag("Chao"))
                {
                    LoadScenes2();
                }
        }

            
            void LoadScenes1()
            {
                SceneManager.LoadScene("Derrota");
            }
        }
    }
```
-------------------------------------------------------------------
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{

    public Camera playerCamera;
    public float walkSpeed = 6f;
    public float runSpeed = 12f;
    public float jumpPower = 7f;
    public float gravity = 10f;
    public float lookSpeed = 2f;
    public float lookXLimit = 45f;
    public float defaultHeight = 2f;
    public float crouchHeight = 1f;
    public float crouchSpeed = 3f;

    private Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0;
    private CharacterController characterController;

    private bool canMove = true;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
       
    }

    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }
        characterController.Move(moveDirection * Time.deltaTime);
        if (Input.GetKey(KeyCode.R) && canMove)
        {
            characterController.height = crouchHeight;
            walkSpeed = crouchSpeed;
            runSpeed = crouchSpeed;

        }
        else
        {
            characterController.height = defaultHeight;
            walkSpeed = 6f;
            runSpeed = 12f;
        }

        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }
    }
}
```
---------------------------------------------------------------

---------------------------------------------------------------

```csharp
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
```


---------------------------------------------------------------


```csharp
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
```

-------------------------------------------------------------------------------------

```csharp
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
```

-----------------------------------------------------------------------------------------

```csharp
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Magia : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 20f * Time.deltaTime);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Destroy(this.gameObject);
        }
    }
}
```

-----------------------------------------------------------------------------------------

```csharp
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
```

---------------------------------------------------------------------------------------

```csharp
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
```

-----------------------------------------------------------------------------------------------


