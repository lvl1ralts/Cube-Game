
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text Score;

     void Update()
    {
        Score.text=player.position.z.ToString("0");
    }
}
