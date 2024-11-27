--------------------------------------------------------------------------------------
>[!Important]
>
>
>Projeto: Criação de cena usando filme/série como referência.
>
>Filme/Série usado: Sakura CardCaption
>
>
>Escola: Etec Professor Basilides de Godoy
>
>Turma: 2 MTEC Programação de Jogos Digitais
>
>Nome dos participantes: Daniel Carvalho da Silva & Igor Cafazzi


# SAKURA HOPE (SAKURA'S CARDPCAPTION INSPIRATION)
![Repository Banner](https://github.com/user-attachments/assets/f90ba345-1b50-4f09-bf0a-6f9206c910da)

--------------------------------------------------------------------------------------



# DRIVER ATUALIZADO!

https://drive.google.com/file/d/16jwjwsKd6BwQW0H0e0nP92frHLxEXAQv/view?usp=sharing

# VIDEO ATUALIZADO!

https://drive.google.com/file/d/1OR4JvSr23NMEF7qWJ47SpqGZiZYVAnaV/view?usp=sharing




----------------------------------------------------------------------------------------

### Enredo && Ideia

Para a criação do jogo, primeiro analisamos alguns episódios do série animada, Sakura CardCaptors (Primeira temporada), que tiveram o uso da transformação, e, decidimos fazer uma breve adaptação dos primeiros episódios, onde a Sakura enfrenta o seu primeiro inimigo. Com isso fizemos um jogo semelhante a tal cena, onde a Sakura vê o monstro e anda sobre tetos para chegar nela, para quando chegar, enfrentar o monstro e finalmente conseguir ativar a transformação para enfrenta-lo, salvando a cidade.

----------------------------------------------------------------------------------------

### Gameplay Geral

Utilizamos a movimentação básica com o Vector3, entregando liberdade perante todos os eixos, X, Y e Z. Aproveitando esse método utilizado, pegamos e fizemos os nossos botões interativos, sendo os movimentos no chão (InGround) W, A, S, D,  para o básico (Eixos X e Z)  e outras alterações como, "Space" para pular (Eixo Y). 
Com adição, temos o botão Shift, que acelera a velocidade de movimento pelos eixos, e, o botão R que seria para "agachar" ou comumente chamado, crouch.

Indo para outros lados, temos a utilização de alguns botões especiais, sendo eles a transformação e posteriormente o ataque.
Entregamos o botão Q, para adicionar uma transformação que puxa outro Prefab com efeitos visuais, possibilitando o player de dar dano contra o Boss.
Assim, após entrar na transformação, é entregue a possibilidade do uso de ataques poderosos. Com o botão E, é lançado uma rajada de energia que ao encostar retira uma parte da vida do próprio Boss.

----------------------------------------------------------------------------------------

### Mapas

1° Mapa (Caminho para o Destino): 
Para o primeiro mapa, queremos entregar uma oportunidade ao jogador de entender como funciona a movimentação, assim, utilizamos um desafio de Parkour; sendo algo simples, com a Sakura pulando de casa em casa tentando chegar ao destino, sendo ele, o Boss.
É um mapa extremamente fácil, que remete as ações dos primeiros episódios, em um momento na call Sakura não conseguia voar em sua varinha. 
Caso o Player caia no chão, ele será retornado para o ponto de início, tendo que recomeçar o Parkour completo.


2° Mapa (A batalha decisiva): 
Indo para o segundo mapa, começamos uma parte bem diferente da anterior. Uma batalha se inicia contra o Boss nomeado de "Boo".
O Boss ficará seguindo o player por todo o mapa, que tem o foco de conseguir encosta-lo para conseguir derrotar ele. Entretanto, o player agora consegue contra-atacar usando a sua transformação, que após acertar uma certa quantidade, o Boss morre e puxa o menu.

----------------------------------------------------------------------------------------

#### Mapas Extras
Menu: É a primeira tela do jogo. Ela serve para iniciar a sua jogatina, ou, apenas sair do jogo. Além de te introduzir para o tema abordado no jogo.

Missao(Pré Mapa da cidade): Um mapa simples que serve como indicativo do motivo para o que você está fazendo, e para onde você irá.

Derrota(Batalha do Boss): Caso você perca para o Boss, ou seja, você for acertado por ele, você será colocado nesta cena de derrota, o que te entrega a oportunidade de esperar um pouco, se preparar e colocar para tentar novamente. 

Vitoria(Batalha do Boss): Com você reduzindo a fonte de vida do Boss para "0", você será teletransportado para essa cena, que agradece e parabeniza a sua vitória. Com isso a cena te possibilita a voltar para o Menu, podendo reiniciar ou apenas sair do jogo.

----------------------------------------------------------------------------------------

### AssetStore

| Website&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; | Description |
| ----------------------- | ------------------ |
| [Google Fonts](https://fonts.google.com/)| Library of around 1000 free licensed font families |
| [DaFont](https://www.dafont.com/)| Archive of freely downloadable fonts |
| [Use & Modify](https://usemodify.com/)| Personal selection of beautiful, classy, punk, professional, incomplete, weird typefaces |
| [1001 Free Fonts](https://www.1001freefonts.com/)| I think the name speaks for itself :smirk: |
| [Font Squirrel](https://www.fontsquirrel.com/)| Font Squirrel scours the internet for high quality, legitimately free fonts |
| [Font Fabric](https://www.fontfabric.com/free-fonts/)| A digital type foundry crafting retail fonts and custom typography for various brands |
| [Just Free Fonts](https://justfreefonts.com/)| A hand-curated collection of freeware, open-source, and public domain fonts intended for commercial use |
| [Tiff](https://winniethemu.github.io/tiff/)| A type diff tool that visually contrasts the differences between two fonts  |
| [TypeKit Practice](https://practice.typekit.com/)| Learn about typography practices |
| [Fontjoy](https://fontjoy.com/)| Generate font pairing in one click |
| [Golden Ratio](https://grtcalculator.com/)| Golden Ratio Typography Calculator |
| [FontGet](https://www.fontget.com/) | Has a variety of fonts available to download and sorted neatly with tags |
| [FontPair](https://fontpair.co/) | Helps you pair Google Fonts together
| [Font Space](https://www.fontspace.com/)| A designer-centered free font website that has quick customizable previews |
| [Abstract Fonts](http://www.abstractfonts.com/)| Fonts free for personal and commercial use |
| [Free Typography](https://freetypography.com/)| A list of high quality fonts |
| [Leon Sans](https://github.com/cmiscm/leonsans/)| A geometric sans-serif typeface made with code |
| [Lexend](https://www.lexend.com/)| A variable font empirically shown to significantly improve reading-proficiency |
| [Fonts for Apple Platforms](https://developer.apple.com/fonts/)| Get the details, frameworks, and tools you need to use system fonts for Apple platforms in your apps |


<div align="right">
    <b><a href="#table-of-contents">↥ Back To Top</a></b>
</div>

----------------------------------------------------------------------------------------

### Prefabs && Modelos
![Derrotada](https://github.com/user-attachments/assets/6c1d26f4-f2fa-460a-bcf4-0e25c4d94847)
![Boo](https://github.com/user-attachments/assets/8e52eff2-453f-4d6c-b2ae-c7b732734ef5)
![Missãop](https://github.com/user-attachments/assets/ab674fcc-acf3-4c99-a08b-ba6c850641a6)
![Menu](https://github.com/user-attachments/assets/f715675d-b088-4149-9f7b-11160647fc04)
![MapaCidade](https://github.com/user-attachments/assets/1d6466bb-8bb0-49d3-8f65-6bb1f0eab940)
![Mapa Boss](https://github.com/user-attachments/assets/ee736eb2-2c4e-4d01-968a-afe189f2ccd8)
![Assets casas](https://github.com/user-attachments/assets/18bf9e84-d7cd-4f4b-be1e-638bd8c3847c)
![Ambiente](https://github.com/user-attachments/assets/24153abd-0e23-48aa-9017-6990f89195e8)
![Vitoria](https://github.com/user-attachments/assets/5123fcf8-98c7-493d-9d30-05c50f218694)


https://github.com/user-attachments/assets/14a7290d-9621-4274-968d-93fa17ac37f4


----------------------------------------------------------------------------------------

### VFX

----------------------------------------------------------------------------------------

### Tags

---------------------------------------------------------------------------------------

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


