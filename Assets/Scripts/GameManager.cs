using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreTextInGame;
    [SerializeField] private TMP_Text scoreTextDeathUI;
    [SerializeField] private TMP_Text scoreTextTravelled;
    //[SerializeField] AudioSource PointSound;
    [SerializeField] private int coins;
    [SerializeField] private int distanceTravelled;

    public void IncreaseScore()
    {
        coins++;
        scoreTextInGame.text = coins.ToString();
        scoreTextDeathUI.text = coins.ToString();
        //PointSound.Play();
        //Debug.Log(score);
    }

    public void IncreaseDistance()
    {

        distanceTravelled += 2;
        scoreTextTravelled.text = distanceTravelled.ToString() + " M ";
    }
}