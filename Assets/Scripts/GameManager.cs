using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreTextInGame;
    [SerializeField] private TMP_Text scoreTextDeathUI;
    //[SerializeField] AudioSource PointSound;
    [SerializeField] private int score;

    public void IncreaseScore()
    {
        score++;
        scoreTextInGame.text = score.ToString();
        scoreTextDeathUI.text = score.ToString();
        //PointSound.Play();
        //Debug.Log(score);
    }
}