using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class GetText : MonoBehaviour
{
    public Transform contentWindow;
    public Text recallTextObject;
    private List<GameObject> instantiatedObjects = new List<GameObject>();
    [SerializeField]private Mes mesInstance; // �Ω�s�x Mes �������
    private string imagesFolderPath = @"C:\Users\USER\Test3\Assets\StreamingAssets\Images"; // ��Ƨ����|

    void Awake()
    {
        // ��� Mes �������
        //mesInstance = FindObjectOfType<Mes>();
    }

    void Update()
    {
        if (mesInstance == null)
        {
            Debug.LogError("Mes instance not found");
            return;
        }

        // ��� ReadMes ����
        string readMesValue = mesInstance.ReadMes;
        recallTextObject.text = readMesValue;

        // �C����s�ɲM�����e��ܪ����e
        //ClearOldObjects();

        /*
        // ��� ReadMes �����e�ιϤ�
        if (!string.IsNullOrEmpty(readMesValue))
        {
            string imagePath = Path.Combine(imagesFolderPath, readMesValue);

            if (File.Exists(imagePath))
            {
                // �[���Ϥ�
                byte[] fileData = File.ReadAllBytes(imagePath);
                Texture2D texture = new Texture2D(2, 2);
                texture.LoadImage(fileData); // �`�N: LoadImage �|�л\�� texture ������

                // �Ыطs���Ϥ�����
                GameObject newImageObject = new GameObject("ImageObject");
                newImageObject.transform.SetParent(contentWindow, false);
                Image imageComponent = newImageObject.AddComponent<Image>();
                imageComponent.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
                instantiatedObjects.Add(newImageObject); // �x�s�s�Ыت�����
            }
            else
            {
                // �Ыطs���奻����
                GameObject newRecallTextObject = Instantiate(recallTextObject, contentWindow);
                newRecallTextObject.GetComponent<Text>().text = readMesValue;
                instantiatedObjects.Add(newRecallTextObject); // �x�s�s�Ыت�����
            }
        
        }
        */
    }

    void ClearOldObjects()
    {
        foreach (GameObject obj in instantiatedObjects)
        {
            Destroy(obj); // �R�����e�Ыت�����
        }
        instantiatedObjects.Clear(); // �M�ŦC��
    }
}
