using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public static GameSystem instance;

    public int Target;

    public bool SistemAcak;

    [System.Serializable]

    public class DataGame
    {
        public string Nama;
        public Sprite Gambar;
    }

    [Header("Settingan Standar")]
    public DataGame[] DataPermainan;

    [Space]
    [Space]
    [Space]

    public Obj_TempatDrop[] Drop_Tempat;
    public Obj_Drag[] Drag_Obj;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    public List<int> _AcakSoal = new List<int>();
    public List<int> _AcakPos = new List<int>();
    public void AcakSoal()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
