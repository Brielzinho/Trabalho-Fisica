using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipalMenager : MonoBehaviour
{
    [SerializeField] private string Pendulo;
    [SerializeField] private GameObject PainelMenuInicial;
    [SerializeField] private GameObject PainelOpcoes;
    public void jogar()
    {
        SceneManager.LoadScene(Pendulo);
    }

    public void AbrirOpcoes()
    {
        PainelMenuInicial.SetActive(false);
        PainelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        PainelOpcoes.SetActive(false);
        PainelMenuInicial.SetActive(true);

    }

    public void SairJogo()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
}
