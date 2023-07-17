using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Unity.VisualScripting;
using MusicDosyaNM;

public class MantarEnergy : MonoBehaviour
{

    private GameObject _music;
    private MusicDosya _musicDosyalar;
    private FirstPersonController _firstPersonController;
    [SerializeField] private int Number;
    private void Start()
    {
        _music = GameObject.Find("AudioManager");
        //_musicDosyalar = _music.GetComponent(typeof(MusicDosya)) as MusicDosya;
        _firstPersonController= GetComponent<FirstPersonController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MantarEnergy"))
        {
            Destroy(other.gameObject);
            //AudioSource.PlayClipAtPoint(_musicDosyalar.music[Number], gameObject.transform.position);
            _firstPersonController.SprintSpeed = 9.0f;
            Invoke("BackNormalSpeed",3.0f);
        }
    }

    private void BackNormalSpeed()
    {
        _firstPersonController.SprintSpeed = 5.0f;
    }
}
