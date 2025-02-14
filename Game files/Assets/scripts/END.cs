
using UnityEngine;

public class END : MonoBehaviour
{
    public GameManager manager;
    void OnTriggerEnter ()
    {
        manager.Completelevel();
    }
}
