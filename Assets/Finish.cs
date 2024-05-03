using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Menu");
        }
        else if (collision.gameObject.name == "Player1")
        {
            SceneManager.LoadScene("SampleScene2");
        }
    }
}