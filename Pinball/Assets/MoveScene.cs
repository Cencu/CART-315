using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveScene : MonoBehaviour
{
    [SerializeField] private string SecondLevel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            SceneManager.LoadScene(SecondLevel);
        }
    }
}
