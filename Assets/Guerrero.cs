using UnityEngine;

public class Guerrero : Personaje
{
    #region Private
    private int ira;
    #endregion

    #region Getters
    public int Ira => ira;
    #endregion

    #region Constructors
    public Guerrero() : base()
    {
        ira = 0;
    }

    public Guerrero(string _charName, int _fuerza, int _defensa, int _vida, int _ira)
        : base(_charName, _fuerza, _defensa, _vida)
    {
        ira = _ira;
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
        Debug.Log($"El guerrero {CharName} ha sido destruido.");
    }
    #endregion

    #region Methods
    public void AumentarIra(int cantidad)
    {
        ira += cantidad;
    }
    #endregion
}