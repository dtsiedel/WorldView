using UnityEngine;
using UnityEngine.SceneManagement;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Examples
{
	// This script is a simple example of how an interactive item can
	// be used to change things on gameobjects by handling events.
	public class SceneSwitchButton : MonoBehaviour
	{
		[SerializeField] private VRInteractiveItem m_InteractiveItem;
		[SerializeField] private Renderer m_Renderer;


		private void Awake ()
		{
		}


		private void OnEnable()
		{
			m_InteractiveItem.OnOver += HandleOver;
			m_InteractiveItem.OnOut += HandleOut;
			m_InteractiveItem.OnClick += HandleClick;
			m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
		}


		private void OnDisable()
		{
			m_InteractiveItem.OnOver -= HandleOver;
			m_InteractiveItem.OnOut -= HandleOut;
			m_InteractiveItem.OnClick -= HandleClick;
			m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
		}


		//Handle the Over event
		private void HandleOver()
		{
			
		}


		//Handle the Out event
		private void HandleOut()
		{
			
		}


		//Handle the Click event
		private void HandleClick()
		{
			SceneManager.LoadScene (gameObject.name);
		}


		//Handle the DoubleClick event
		private void HandleDoubleClick()
		{
			
		}
	}

}
