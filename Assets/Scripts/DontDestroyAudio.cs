using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    private static DontDestroyAudio _instancia;

    void Awake()
    {
       
        if (_instancia == null)
        {
            _instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            
            Destroy(gameObject);
        }
    }
}
