using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TMP_Text scoreTextInGame;
    public TMP_Text scoreTextDeathUI;
    //[SerializeField] AudioSource PointSound;
    public int score;
    public void IncreaseScore()
    {
        score++;
        scoreTextInGame.text = score.ToString();
        scoreTextDeathUI.text = score.ToString();
        //PointSound.Play();
        Debug.Log(score);
    }
}