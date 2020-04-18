using UnityEditor;
using UnityEngine;

namespace UniProjectWindowMenuCustomizer.Internal
{
	[CustomPropertyDrawer( typeof( ProjectWindowMenuSettings.Data ) )]
	internal sealed class ProjectWindowMenuSettingsDataDrawer : PropertyDrawer
	{
		public override void OnGUI
		(
			Rect               position,
			SerializedProperty property,
			GUIContent         label
		)
		{
			using ( new EditorGUI.PropertyScope( position, label, property ) )
			{
				position.height = EditorGUIUtility.singleLineHeight;

				var nameRect = new Rect( position )
				{
					width = position.width,
				};

				var menuItemPathRect = new Rect( position )
				{
					y = nameRect.yMax + 2,
				};

				var nameProperty     = property.FindPropertyRelative( "m_name" );
				var menuItemProperty = property.FindPropertyRelative( "m_menuItemPath" );

				EditorGUI.PropertyField( nameRect, nameProperty );
				EditorGUI.PropertyField( menuItemPathRect, menuItemProperty );
			}
		}
	}
}