using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;

    public GameManager gameOver;

    void Update(){
        if (gameOver.hasEnded == false)
        {
            scoreText.text = player.position.z.ToString("0");
        }
        else
        {
            scoreText.text = "game over";
        }
    }

}