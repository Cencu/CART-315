using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveToThird : MonoBehaviour
{
    [SerializeField] private string thirdLevel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            SceneManager.LoadScene(thirdLevel);
        }
    }
}