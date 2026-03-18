using UnityEngine;

public class BotoesBh : MonoBehaviour
{
    //referencia da imagem vermelha
    public GameObject ledRed;
    public GameObject ledGreen;

    public GameObject panel1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void Btn1()
    {
        print("Olá Mundo!");
        //pega o nome da referencia e deixa desativado
        ledRed.SetActive(false);

    }

    public void Btn2()
    {
        print("Olá Mundo Novo!");
        ledGreen.SetActive(!ledGreen.activeSelf);

    }

    public void BtnOpenPanel1()
    {
        panel1.GetComponent<Animator>().SetBool("PanelOn", true);

    }

    public void BtnCloseP1()
    {

        panel1.GetComponent<Animator>().SetBool("PanelOn", false);

    }
}
