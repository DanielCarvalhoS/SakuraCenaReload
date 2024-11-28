using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("paredetp"))
        {
            LoadScenes1();
        }
    }
    void LoadScenes1()
    {
        SceneManager.LoadScene("LutaBoss");
    }

}
