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


    

