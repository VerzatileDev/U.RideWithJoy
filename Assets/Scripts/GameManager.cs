using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text coinTextInGame;
    [SerializeField] private TMP_Text coinTextDeathUI;
    [SerializeField] private TMP_Text distanceTextTravelled;
    //[SerializeField] AudioSource PointSound;
    [SerializeField] private int coins;
    [SerializeField] private int distanceTravelled;

    public void IncreaseScore()
    {
        coins++;
        coinTextInGame.text = coins.ToString();
        coinTextDeathUI.text = coins.ToString();
        //PointSound.Play();
        //Debug.Log(score);
    }

    public void IncreaseDistance()
    {

        distanceTravelled += 2;
        distanceTextTravelled.text = distanceTravelled.ToString() + " M ";
    }
}