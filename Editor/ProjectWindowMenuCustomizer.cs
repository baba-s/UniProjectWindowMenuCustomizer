using System.Linq;
using UnityEditor;
using UnityEngine;

namespace KoganeEditorLib.Internal
{
	[InitializeOnLoad]
	internal static class ProjectWindowMenuCustomizer
	{
		private static ProjectWindowMenuSettings m_settings;

		static ProjectWindowMenuCustomizer()
		{
			EditorApplication.projectWindowItemOnGUI += OnGUI;
		}

		private static ProjectWindowMenuSettings GetSettings()
		{
			if ( m_settings == null )
			{
				m_settings = AssetDatabase
						.FindAssets( "t:ProjectWindowMenuSettings" )
						.Select( AssetDatabase.GUIDToAssetPath )
						.Select( AssetDatabase.LoadAssetAtPath<ProjectWindowMenuSettings> )
						.FirstOrDefault()
					;
			}

			return m_settings;
		}

		private static void OnGUI( string guid, Rect selectionRect )
		{
			if ( Event.current.type != EventType.ContextClick ) return;

			var settings = GetSettings();

			if ( settings == null ) return;

			Event.current.Use();

			var list        = settings.List;
			var genericMenu = new GenericMenu();

			for ( var i = 0; i < list.Count; i++ )
			{
				var data = list[ i ];
				var name = data.Name;

				if ( data.IsSeparator )
				{
					genericMenu.AddSeparator( name );
				}
				else
				{
					var menuItemPath = data.MenuItemPath;
					var content      = new GUIContent( name );

					genericMenu.AddItem
					(
						content: content,
						@on: false,
						func: () => EditorApplication.ExecuteMenuItem( menuItemPath )
					);
				}
			}

			genericMenu.ShowAsContext();
		}
	}
}