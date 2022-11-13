using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public TMPro.TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText(player.position.z.ToString("0"));
    }
}
