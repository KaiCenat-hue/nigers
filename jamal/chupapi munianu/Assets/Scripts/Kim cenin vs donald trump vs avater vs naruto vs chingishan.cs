using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Kimceninvsdonaldtrumpvsavatervsnarutovschingishan : MonoBehaviour
{
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        pv = GetComponent<PhotonView>();
        info.render = gameObject;
    }

    [SerializeField] private BulletInfo info;
    private Rigidbody rb;
    private PhotonView pv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!pv.IsMine) return;
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponentInParent<PlayerSetting>().TakeDamage(info.damage);
            PhotonNetwork.Destroy(gameObject);
        }
    }

}
