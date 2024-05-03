using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static public int myScore;
 
    void Update()
    {
        GetComponent<Text>().text = "Score: " + myScore;
    }
}
