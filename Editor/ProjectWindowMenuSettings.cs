using System;
using System.Collections.Generic;
using UnityEngine;

namespace KoganeEditorLib.Internal
{
	[CreateAssetMenu( fileName = "ProjectWindowMenuSettings", order = 9001 )]
	internal sealed class ProjectWindowMenuSettings : ScriptableObject
	{
		[SerializeField] private Data[] m_list = null;

		public IList<Data> List => m_list;

		public void Reset()
		{
			m_list = new Data[0];
		}

		public void ResetToDefault()
		{
			m_list = new[]
			{
				new Data( "Create/Folder", "Assets/Create/Folder" ),

				new Data( "Create/" ),

				new Data( "Create/C# Script", "Assets/Create/C# Script" ),

				new Data( "Create/Shader/Standard Surface Shader", "Assets/Create/Shader/Standard Surface Shader" ),
				new Data( "Create/Shader/Unlit Shader", "Assets/Create/Shader/Unlit Shader" ),
				new Data( "Create/Shader/Image Effect Shader", "Assets/Create/Shader/Image Effect Shader" ),
				new Data( "Create/Shader/Compute Shader", "Assets/Create/Shader/Compute Shader" ),
				new Data( "Create/Shader/Ray Tracing Shader", "Assets/Create/Shader/Ray Tracing Shader" ),

				new Data( "Create/Shader/" ),

				new Data( "Create/Shader/Shader Variant Collection", "Assets/Create/Shader/Shader Variant Collection" ),

				new Data( "Create/Testing/Tests Assembly Folder", "Assets/Create/Testing/Tests Assembly Folder" ),
				new Data( "Create/Testing/C# Test Script", "Assets/Create/Testing/C# Test Script" ),

				new Data
				(
					"Create/Playables/Playable Behaviour C# Script",
					"Assets/Create/Playables/Playable Behaviour C# Script"
				),
				new Data
				(
					"Create/Playables/Playable Asset C# Script",
					"Assets/Create/Playables/Playable Asset C# Script"
				),

				new Data( "Create/Assembly Definition", "Assets/Create/Assembly Definition" ),
				new Data( "Create/Assembly Definition Reference", "Assets/Create/Assembly Definition Reference" ),

				new Data( "Create/TextMeshPro/Font Asset", "Assets/Create/TextMeshPro/Font Asset" ),
				new Data( "Create/TextMeshPro/Sprite Asset", "Assets/Create/TextMeshPro/Sprite Asset" ),
				new Data( "Create/TextMeshPro/Color Gradient", "Assets/Create/TextMeshPro/Color Gradient" ),
				new Data( "Create/TextMeshPro/Style Sheet", "Assets/Create/TextMeshPro/Style Sheet" ),

				new Data( "Create/" ),

				new Data( "Create/Scene", "Assets/Create/Scene" ),
				new Data( "Create/Prefab Variant", "Assets/Create/Prefab Variant" ),

				new Data( "Create/" ),

				new Data( "Create/Audio Mixer", "Assets/Create/Audio Mixer" ),

				new Data( "Create/" ),

				new Data( "Create/Material", "Assets/Create/Material" ),
				new Data( "Create/Lens Flare", "Assets/Create/Lens Flare" ),
				new Data( "Create/Render Texture", "Assets/Create/Render Texture" ),
				new Data( "Create/Lightmap Parameters", "Assets/Create/Lightmap Parameters" ),
				new Data( "Create/Custom Render Texture", "Assets/Create/Custom Render Texture" ),

				new Data( "Create/" ),

				new Data( "Create/Sprite Atlas", "Assets/Create/Sprite Atlas" ),

				new Data( "Create/Sprites/Square", "Assets/Create/Sprites/Square" ),
				new Data( "Create/Sprites/Triangle", "Assets/Create/Sprites/Triangle" ),
				new Data( "Create/Sprites/Diamond", "Assets/Create/Sprites/Diamond" ),
				new Data( "Create/Sprites/Hexagon", "Assets/Create/Sprites/Hexagon" ),
				new Data( "Create/Sprites/Circle", "Assets/Create/Sprites/Circle" ),
				new Data( "Create/Sprites/Polygon", "Assets/Create/Sprites/Polygon" ),

				new Data( "Create/Tile", "Assets/Create/Tile" ),

				new Data( "Create/" ),

				new Data( "Create/Animator Controller", "Assets/Create/Animator Controller" ),
				new Data( "Create/Animation", "Assets/Create/Animation" ),
				new Data( "Create/Animator Override Controller", "Assets/Create/Animator Override Controller" ),
				new Data( "Create/Avatar Mask", "Assets/Create/Avatar Mask" ),

				new Data( "Create/" ),

				new Data( "Create/Timeline", "Assets/Create/Timeline" ),
				new Data( "Create/Signal", "Assets/Create/Signal" ),

				new Data( "Create/" ),

				new Data( "Create/Physic Material", "Assets/Create/Physic Material" ),
				new Data( "Create/Physics Material 2D", "Assets/Create/Physics Material 2D" ),

				new Data( "Create/" ),

				new Data( "Create/GUI Skin", "Assets/Create/GUI Skin" ),
				new Data( "Create/Custom Font", "Assets/Create/Custom Font" ),

				new Data( "Create/UIElements/USS File", "Assets/Create/UIElements/USS File" ),
				new Data( "Create/UIElements/UXML Template", "Assets/Create/UIElements/UXML Template" ),

				new Data( "Create/UIElements/" ),

				new Data( "Create/UIElements/Editor Window", "Assets/Create/UIElements/Editor Window" ),

				new Data( "Create/" ),

				new Data( "Create/Legacy/Cubemap", "Assets/Create/Legacy/Cubemap" ),

				new Data( "Create/" ),

				new Data( "Create/Brush", "Assets/Create/Brush" ),
				new Data( "Create/Terrain Layer", "Assets/Create/Terrain Layer" ),

				new Data( "Show in Explorer", "Assets/Show in Explorer" ),
				new Data( "Open", "Assets/Open" ),
				new Data( "Delete", "Assets/Delete" ),
				new Data( "Rename", "Assets/Rename" ),
				new Data( "Copy Path", "Assets/Copy Path" ),

				new Data(),

				new Data( "Open Scene Additive", "Assets/Open Scene Additive" ),

				new Data(),

				new Data( "View in Package Manager", "Assets/View in Package Manager" ),

				new Data(),

				new Data( "Import New Asset...", "Assets/Import New Asset..." ),
				new Data( "Import Package/Custom Package...", "Assets/Import Package/Custom Package..." ),
				new Data( "Export Package", "Assets/Export Package..." ),
				new Data( "Find References In Scene", "Assets/Find References In Scene" ),
				new Data( "Select Dependencies", "Assets/Select Dependencies" ),

				new Data(),

				new Data( "Refresh", "Assets/Refresh" ),
				new Data( "Reimport", "Assets/Reimport" ),

				new Data(),

				new Data( "Reimport All", "Assets/Reimport All" ),

				new Data(),

				new Data( "Extract From Prefab", "Assets/Extract From Prefab" ),

				new Data(),

				new Data( "Run API Updater...", "Assets/Run API Updater..." ),

				new Data(),

				new Data( "Update UIElements Schema", "Assets/Update UIElements Schema" ),

				new Data(),

				new Data( "Open C# Project", "Assets/Open C# Project" ),
			};
		}

		[Serializable]
		internal sealed class Data
		{
			[SerializeField] private string m_name         = string.Empty;
			[SerializeField] private string m_menuItemPath = string.Empty;

			public string Name         => m_name;
			public string MenuItemPath => m_menuItemPath;
			public bool   IsSeparator  => string.IsNullOrWhiteSpace( m_menuItemPath );

			public Data()
			{
			}

			public Data( string name )
			{
				m_name = name;
			}

			public Data( string name, string menuItemPath )
			{
				m_name         = name;
				m_menuItemPath = menuItemPath;
			}
		}
	}
}