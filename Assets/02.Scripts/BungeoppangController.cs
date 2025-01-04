using UnityEngine;

public class BungeoppangController : MonoBehaviour
{
    private ComponentsSO currentBungeobbang;

    [SerializeField] public GameObject bungeoppang1;
    [SerializeField] public GameObject bungeoppang2;
    [SerializeField] public GameObject bungeoppang3;
    
    // �ؾ�� ���̴��� ��Ÿ���� ���� ��
    public bool isBungeoppang1Visible  = false;
    public bool isBungeoppang2Visible = false;
    public bool isBungeoppang3Visible = false;

    // Ư���� �ؾ���� ��Ÿ���� ���� ��
    public bool isBungeoppang1Special = false;
    public bool isBungeoppang2Special = false;
    public bool isBungeoppang3Special = false;

    // ���� ���� �ؾ�� �����
    public void CreateBungeobbang()
    {
        // �� ���̴� �ؾ ���̰� �ϱ�
        if (isBungeoppang1Visible == false && isBungeoppang1Special == false)
        {
            bungeoppang1.SetActive(true);
            isBungeoppang1Visible = true;
        }
        else if (isBungeoppang2Visible == false && isBungeoppang2Special == false)
        {
            bungeoppang2.SetActive(true);
            isBungeoppang2Visible = true;
        }
        else if (isBungeoppang3Visible == false && isBungeoppang3Special == false)
        {
            bungeoppang3.SetActive(true);
            isBungeoppang3Visible = true;
        }
    }

    // �ؾ�� �ʸ� ä���
    public void FillBungeobbang(GameObject emptyBungeobbang, GameObject filling)
    {
        Components component = filling.GetComponent<Components>();
        currentBungeobbang = component.componentData;

        emptyBungeobbang.SetActive(false);

        // �� �ؾ�� ������ Ư���� �ؾ���� �����
        if (emptyBungeobbang == bungeoppang1 && isBungeoppang1Visible == true && isBungeoppang1Special == false)
        {
            MakeSpecialBungeobbang(emptyBungeobbang.transform.position, 1, filling);
        }
        else if (emptyBungeobbang == bungeoppang2 && isBungeoppang2Visible == true && isBungeoppang2Special == false)
        {
            MakeSpecialBungeobbang(emptyBungeobbang.transform.position, 2, filling);
        }
        else if (emptyBungeobbang == bungeoppang3 && isBungeoppang3Visible == true && isBungeoppang3Special == false)
        {
            MakeSpecialBungeobbang(emptyBungeobbang.transform.position, 3, filling);
        }
    }

    // Ư���� �ؾ �����
    void MakeSpecialBungeobbang(Vector3 bungeobbangPos, int bungeobbangIndex, GameObject filling)
    {
        GameObject output = Instantiate(
        currentBungeobbang.Bungeobbang,
        bungeobbangPos,
        Quaternion.identity
        );

        if (bungeobbangIndex == 1)
        {
            isBungeoppang1Visible = false;
            isBungeoppang1Special = true;
        }
        else if (bungeobbangIndex == 2)
        {
            isBungeoppang2Visible = false;
            isBungeoppang2Special = true;
        }
        else if(bungeobbangIndex == 3)
        {
            isBungeoppang3Visible = false;
            isBungeoppang3Special = true;
        }

        Destroy(filling);
    }
}
