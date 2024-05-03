using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountdownTimer : MonoBehaviour
{
    public float countdownTime = 10f; // ระยะเวลาที่ต้องการให้นับถอยหลัง
    private float currentTime;
    public Text countdownText; // ตัวแปรสำหรับ Text UI

    void Start()
    {
        // เริ่ม Coroutine สำหรับการนับถอยหลัง
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        currentTime = countdownTime;

        // นับถอยหลังจนกว่าเวลาจะลดลงเป็น 0
        while (currentTime > 0)
        {
            yield return new WaitForSeconds(1f); // รอเวลา 1 วินาที
            currentTime--;
            // แสดงผลลัพธ์ใน Text UI
            countdownText.text = "Time remaining: " + currentTime.ToString();
        }

        // เมื่อเวลานับถอยหลังลดลงเป็น 0 แสดงข้อความเตือน
        countdownText.text = "Time's up!";
    }
}