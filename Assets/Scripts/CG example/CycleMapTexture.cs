using System.Linq;
using UnityEngine;

public class CycleMapTexture : MonoBehaviour
{
	[SerializeField] Material defaultMaterial;
	public Material[] ogMaterials;
	public Material[] defaultMaterialArray;
	private Renderer objectRenderer;
	private bool swapped;

	private void Awake()
	{
		ogMaterials = GetComponent<Renderer>().sharedMaterials;
		Material[] tempArray = new Material[ogMaterials.Length];
		for (int i = 0; i < tempArray.Count(); i++)
		{
			tempArray[i] = defaultMaterial;
		}
		objectRenderer = GetComponent<Renderer>();
		defaultMaterialArray = tempArray;
	}
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.T))
		{
			swapMaterials();
		}
	}
	private void swapMaterials()
	{
		if (!swapped)
		{
			objectRenderer.sharedMaterials = defaultMaterialArray;
			swapped = true;
		}
		else
		{
			objectRenderer.sharedMaterials = ogMaterials;
			swapped = false;
		}
		Debug.Log(swapped);
	}
}
