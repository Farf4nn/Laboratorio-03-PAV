using UnityEngine;

public class Personaje : MonoBehaviour
{
    #region Private
    private string charName;
    private int fuerza;
    private int defensa;
    private int vida;
    #endregion

    #region Getters
    public string CharName => charName;
    public int Fuerza => fuerza;
    public int Defensa => defensa;
    public int Vida => vida;
    #endregion

    #region Constructors
    public Personaje()
    {
        charName = "Desconocido";
        fuerza = 0;
        defensa = 0;
        vida = 0;
    }

    public Personaje(string _charName, int _fuerza, int _defensa, int _vida)
    {
        charName = _charName;
        fuerza = _fuerza;
        defensa = _defensa;
        vida = _vida;
    }
    #endregion

    #region Unity Methods
    void Start()
    {
        // Aquí podrías inicializar algo si quieres
    }

    void Update()
    {
        // Aquí podrías hacer actualizaciones por frame
    }

    void OnDestroy()
    {
        Debug.Log($"{charName} ha sido destruido.");
    }
    #endregion

    #region Methods
    // Métodos adicionales
    #endregion
}