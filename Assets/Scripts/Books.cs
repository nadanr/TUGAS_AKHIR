using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Books : MonoBehaviour
{
    public TextMeshProUGUI bookInformation;
    public TextMeshProUGUI bookTitle;
    public Image booksUI;
    public int id;

    public void BookId()
    {
        StartCoroutine(BookInfo(id));
    }

    private IEnumerator BookInfo (int id)
    {
        if (id < 0)
        {
            yield break;
        }

        else if(id == 0) //ini buku ttg IT (bisa diganti apa saja kalau mau)
        {
            bookTitle.text = "Informasi Teknologi";
            bookInformation.text = "Buku ini berisi informasi tentang Informasi Teknologi"; // bisa diganti isinya, tinggal atur ukuran dan posisi di editor
            booksUI.gameObject.SetActive(true);
        }

        else if (id == 1) //ini buku ttg Biologi (bisa diganti apa saja kalau mau)
        {
            bookTitle.text = "Biologi";
            bookInformation.text = "Buku ini berisi informasi tentang Biologi"; // bisa diganti isinya, tinggal atur ukuran dan posisi di editor
            booksUI.gameObject.SetActive(true);
        }
        
        else if (id == 2) //ini buku ttg Matematika (bisa diganti apa saja kalau mau)
        {
            bookTitle.text = "Matematika";
            bookInformation.text = "Buku ini berisi informasi tentang Matematika"; // bisa diganti isinya, tinggal atur ukuran dan posisi di editor
            booksUI.gameObject.SetActive(true);
        }

        else if (id == 3) //ini buku ttg Geografi (bisa diganti apa saja kalau mau)
        {
            bookTitle.text = "Geografi";
            bookInformation.text = "Buku ini berisi informasi tentang Geografi"; // bisa diganti isinya, tinggal atur ukuran dan posisi di editor
            booksUI.gameObject.SetActive(true);
        }

        else if (id == 4) //ini buku ttg Sejarah (bisa diganti apa saja kalau mau)
        {
            bookTitle.text = "Sejarah";
            bookInformation.text = "Buku ini berisi informasi tentang Sejarah"; // bisa diganti isinya, tinggal atur ukuran dan posisi di editor
            booksUI.gameObject.SetActive(true);
        }

        else if (id == 5) //ini buku ttg Fisika (bisa diganti apa saja kalau mau)
        {
            bookTitle.text = "Fisika";
            bookInformation.text = "Buku ini berisi informasi tentang Fisika"; // bisa diganti isinya, tinggal atur ukuran dan posisi di editor
            booksUI.gameObject.SetActive(true);
        }

        else if (id == 6) //ini buku ttg Ekonomi (bisa diganti apa saja kalau mau)
        {
            bookTitle.text = "Ekonomi";
            bookInformation.text = "Buku ini berisi informasi tentang Ekonomi"; // bisa diganti isinya, tinggal atur ukuran dan posisi di editor
            booksUI.gameObject.SetActive(true);
        }

        else if (id == 7) //ini buku ttg Agama (bisa diganti apa saja kalau mau)
        {
            bookTitle.text = "Agama";
            bookInformation.text = "Buku ini berisi informasi tentang Agama"; // bisa diganti isinya, tinggal atur ukuran dan posisi di editor
            booksUI.gameObject.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            booksUI.gameObject.SetActive(false);
        }
    }
}
