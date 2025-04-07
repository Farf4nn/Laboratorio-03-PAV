using UnityEngine;

public class Mago : Personaje
{
    #region Private
    private int mana;
    #endregion

    #region Getters
    public int Mana => mana;
    #endregion

    #region Constructors
    public Mago() : base()
    {
        mana = 100;
    }

    public Mago(string _charName, int _fuerza, int _defensa, int _vida, int _mana)
        : base(_charName, _fuerza, _defensa, _vida)
    {
        mana = _mana;
    }

    // Constructor que copia otro mago
    public Mago(Mago otroMago)
        : base(otroMago.CharName, otroMago.Fuerza, otroMago.Defensa, otroMago.Vida)
    {
        mana = otroMago.mana;
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
        Debug.Log($"El mago {CharName} ha sido destruido.");
    }
    #endregion

    #region Methods
    public void UsarHechizo(int costoMana)
    {
        mana -= costoMana;
        if (mana < 0) mana = 0;
    }
    #endregion
}