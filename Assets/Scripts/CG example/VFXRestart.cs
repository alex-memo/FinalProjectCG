using UnityEngine;

public class VFXRestart : MonoBehaviour
{
	private GameObject[] vfx;
	private void Awake()
	{
		vfx = new GameObject[transform.childCount];
		for (int i = 0; i < vfx.Length; i++)
		{
			vfx[i] = transform.GetChild(i).gameObject;
		}
	}
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.F))
		{
			restartVFX();
		}
	}
	private void restartVFX()
	{
		foreach (var _vfx in vfx)
		{
			_vfx.SetActive(false);
			_vfx.SetActive(true);
		}
	}
}
