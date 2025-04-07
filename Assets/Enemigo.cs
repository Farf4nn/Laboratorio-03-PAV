using UnityEngine;

public class Enemigo : MonoBehaviour
{
    #region Private
    private string enemyName;
    private int vida;
    public static int scoreGlobal = 0;
    #endregion

    #region Getters
    public string EnemyName => enemyName;
    public int Vida => vida;
    #endregion

    #region Constructors
    public Enemigo()
    {
        enemyName = "Enemigo desconocido";
        vida = 100;
    }

    public Enemigo(string _enemyName, int _vida)
    {
        enemyName = _enemyName;
        vida = _vida;
    }
    #endregion

    #region Unity Methods
    void Start()
    {
    }

    void Update()
    {
    }

    void OnDestroy()
    {
        scoreGlobal += 10;
        Debug.Log($"{enemyName} ha muerto. Score global: {scoreGlobal}");
    }
    #endregion

    #region Methods
    public void RecibirDa�o(int da�o)
    {
        vida -= da�o;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    #endregion
}