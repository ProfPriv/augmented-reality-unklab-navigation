// Untuk ngatur searchnya

using UnityEngine;
using TMPro;

public class SearchScript : MonoBehaviour
{
    public GameObject ContentHolder;

    public GameObject[] Element;

    public GameObject SearchBar;

    public int totalElements;

    // Start is called before the first frame update
    void Start()
    {
        totalElements = ContentHolder.transform.childCount;

        Element = new GameObject[totalElements];

        for(int i = 0; i < totalElements; i++)
        {
            Element[i] = ContentHolder.transform.GetChild(i).gameObject;
        }
    }

    public void Search()
    {
        string searchText = SearchBar.GetComponent<TMP_InputField>().text.ToLower(); // Mengonversi teks pencarian ke huruf kecil
        int searchTxtLength = searchText.Length;

        foreach (GameObject ele in Element)
        {
            TextMeshProUGUI textComponent = ele.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            string elementText = textComponent.text.ToLower(); // Mengonversi teks elemen ke huruf kecil

            if (elementText.Contains(searchText))
            {
                ele.SetActive(true); // Menampilkan elemen jika teks pencarian ada dalam teks elemen
            }
            else
            {
                ele.SetActive(false); // Menyembunyikan elemen jika teks pencarian tidak ada dalam teks elemen
            }
        }
    }

}
