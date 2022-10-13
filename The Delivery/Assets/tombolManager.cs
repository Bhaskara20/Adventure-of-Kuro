using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tombolManager : MonoBehaviour
{
    public GameObject Awal;
    public GameObject Paket;
    public GameObject Oksigen;
    public GameObject Fuel;
    public GameObject Machine;
    public GameObject GO;
    public Animator terbang;
    public GameObject loading;

    public void AmbilPaket()
    {
        Oksigen.SetActive(true);
        Awal.SetActive(false);
        Paket.SetActive(false);
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void periksaOksigen()
    {
        Oksigen.SetActive(false);
        Fuel.SetActive(true);
    }

    public void periksaFuel()
    {
        Fuel.SetActive(false);
        Machine.SetActive(true);
    }

    public void periksaMesin()
    {
        Machine.SetActive(false);
        GO.SetActive(true);
    }

    public void berangkat()
    {
        GO.SetActive(false);
        terbang.Play("terbang");
        loading.SetActive(true);
        
    }
}
