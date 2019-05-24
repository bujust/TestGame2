using System;
using UnityEngine;

namespace ES3Types
{
	[ES3PropertiesAttribute("_hashTable", "_snapShot", "showEvents", "showContent", "TextureElementSmall", "condensedView", "liveUpdate", "referenceName", "enablePlayMakerEvents", "addEvent", "setEvent", "removeEvent", "contentPreviewStartIndex", "contentPreviewMaxRows", "preFillType", "preFillObjectTypeIndex", "preFillCount", "preFillKeyList", "preFillBoolList", "preFillColorList", "preFillFloatList", "preFillGameObjectList", "preFillIntList", "preFillMaterialList", "preFillObjectList", "preFillQuaternionList", "preFillRectList", "preFillStringList", "preFillTextureList", "preFillVector2List", "preFillVector3List", "preFillAudioClipList", "preFillByteList", "preFillSpriteList", "useGUILayout", "runInEditMode", "enabled", "hideFlags")]
	public class ES3Type_PlayMakerHashTableProxy : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3Type_PlayMakerHashTableProxy() : base(typeof(PlayMakerHashTableProxy))
		{
			Instance = this;
		}

		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (PlayMakerHashTableProxy)obj;
			
			writer.WriteProperty("_hashTable", instance._hashTable);
			writer.WritePrivateField("_snapShot", instance);
			writer.WriteProperty("showEvents", instance.showEvents, ES3Type_bool.Instance);
			writer.WriteProperty("showContent", instance.showContent, ES3Type_bool.Instance);
			writer.WriteProperty("TextureElementSmall", instance.TextureElementSmall, ES3Type_bool.Instance);
			writer.WriteProperty("condensedView", instance.condensedView, ES3Type_bool.Instance);
			writer.WriteProperty("liveUpdate", instance.liveUpdate, ES3Type_bool.Instance);
			writer.WriteProperty("referenceName", instance.referenceName, ES3Type_string.Instance);
			writer.WriteProperty("enablePlayMakerEvents", instance.enablePlayMakerEvents, ES3Type_bool.Instance);
			writer.WriteProperty("addEvent", instance.addEvent, ES3Type_string.Instance);
			writer.WriteProperty("setEvent", instance.setEvent, ES3Type_string.Instance);
			writer.WriteProperty("removeEvent", instance.removeEvent, ES3Type_string.Instance);
			writer.WriteProperty("contentPreviewStartIndex", instance.contentPreviewStartIndex, ES3Type_int.Instance);
			writer.WriteProperty("contentPreviewMaxRows", instance.contentPreviewMaxRows, ES3Type_int.Instance);
			writer.WriteProperty("preFillType", instance.preFillType);
			writer.WriteProperty("preFillObjectTypeIndex", instance.preFillObjectTypeIndex, ES3Type_int.Instance);
			writer.WriteProperty("preFillCount", instance.preFillCount, ES3Type_int.Instance);
			writer.WriteProperty("preFillKeyList", instance.preFillKeyList);
			writer.WriteProperty("preFillBoolList", instance.preFillBoolList);
			writer.WriteProperty("preFillColorList", instance.preFillColorList);
			writer.WriteProperty("preFillFloatList", instance.preFillFloatList);
			writer.WriteProperty("preFillGameObjectList", instance.preFillGameObjectList);
			writer.WriteProperty("preFillIntList", instance.preFillIntList);
			writer.WriteProperty("preFillMaterialList", instance.preFillMaterialList);
			writer.WriteProperty("preFillObjectList", instance.preFillObjectList);
			writer.WriteProperty("preFillQuaternionList", instance.preFillQuaternionList);
			writer.WriteProperty("preFillRectList", instance.preFillRectList);
			writer.WriteProperty("preFillStringList", instance.preFillStringList);
			writer.WriteProperty("preFillTextureList", instance.preFillTextureList);
			writer.WriteProperty("preFillVector2List", instance.preFillVector2List);
			writer.WriteProperty("preFillVector3List", instance.preFillVector3List);
			writer.WriteProperty("preFillAudioClipList", instance.preFillAudioClipList);
			writer.WriteProperty("preFillByteList", instance.preFillByteList);
			writer.WriteProperty("preFillSpriteList", instance.preFillSpriteList);
			writer.WriteProperty("useGUILayout", instance.useGUILayout, ES3Type_bool.Instance);
			writer.WriteProperty("runInEditMode", instance.runInEditMode, ES3Type_bool.Instance);
			writer.WriteProperty("enabled", instance.enabled, ES3Type_bool.Instance);
			writer.WriteProperty("hideFlags", instance.hideFlags);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (PlayMakerHashTableProxy)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "_hashTable":
						instance._hashTable = reader.Read<System.Collections.Hashtable>();
						break;
					case "_snapShot":
					reader.SetPrivateField("_snapShot", reader.Read<System.Collections.Hashtable>(), instance);
					break;
					case "showEvents":
						instance.showEvents = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "showContent":
						instance.showContent = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "TextureElementSmall":
						instance.TextureElementSmall = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "condensedView":
						instance.condensedView = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "liveUpdate":
						instance.liveUpdate = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "referenceName":
						instance.referenceName = reader.Read<System.String>(ES3Type_string.Instance);
						break;
					case "enablePlayMakerEvents":
						instance.enablePlayMakerEvents = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "addEvent":
						instance.addEvent = reader.Read<System.String>(ES3Type_string.Instance);
						break;
					case "setEvent":
						instance.setEvent = reader.Read<System.String>(ES3Type_string.Instance);
						break;
					case "removeEvent":
						instance.removeEvent = reader.Read<System.String>(ES3Type_string.Instance);
						break;
					case "contentPreviewStartIndex":
						instance.contentPreviewStartIndex = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "contentPreviewMaxRows":
						instance.contentPreviewMaxRows = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "preFillType":
						instance.preFillType = reader.Read<PlayMakerCollectionProxy.VariableEnum>();
						break;
					case "preFillObjectTypeIndex":
						instance.preFillObjectTypeIndex = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "preFillCount":
						instance.preFillCount = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "preFillKeyList":
						instance.preFillKeyList = reader.Read<System.Collections.Generic.List<System.String>>();
						break;
					case "preFillBoolList":
						instance.preFillBoolList = reader.Read<System.Collections.Generic.List<System.Boolean>>();
						break;
					case "preFillColorList":
						instance.preFillColorList = reader.Read<System.Collections.Generic.List<UnityEngine.Color>>();
						break;
					case "preFillFloatList":
						instance.preFillFloatList = reader.Read<System.Collections.Generic.List<System.Single>>();
						break;
					case "preFillGameObjectList":
						instance.preFillGameObjectList = reader.Read<System.Collections.Generic.List<UnityEngine.GameObject>>();
						break;
					case "preFillIntList":
						instance.preFillIntList = reader.Read<System.Collections.Generic.List<System.Int32>>();
						break;
					case "preFillMaterialList":
						instance.preFillMaterialList = reader.Read<System.Collections.Generic.List<UnityEngine.Material>>();
						break;
					case "preFillObjectList":
						instance.preFillObjectList = reader.Read<System.Collections.Generic.List<UnityEngine.Object>>();
						break;
					case "preFillQuaternionList":
						instance.preFillQuaternionList = reader.Read<System.Collections.Generic.List<UnityEngine.Quaternion>>();
						break;
					case "preFillRectList":
						instance.preFillRectList = reader.Read<System.Collections.Generic.List<UnityEngine.Rect>>();
						break;
					case "preFillStringList":
						instance.preFillStringList = reader.Read<System.Collections.Generic.List<System.String>>();
						break;
					case "preFillTextureList":
						instance.preFillTextureList = reader.Read<System.Collections.Generic.List<UnityEngine.Texture2D>>();
						break;
					case "preFillVector2List":
						instance.preFillVector2List = reader.Read<System.Collections.Generic.List<UnityEngine.Vector2>>();
						break;
					case "preFillVector3List":
						instance.preFillVector3List = reader.Read<System.Collections.Generic.List<UnityEngine.Vector3>>();
						break;
					case "preFillAudioClipList":
						instance.preFillAudioClipList = reader.Read<System.Collections.Generic.List<UnityEngine.AudioClip>>();
						break;
					case "preFillByteList":
						instance.preFillByteList = reader.Read<System.Collections.Generic.List<System.Byte>>();
						break;
					case "preFillSpriteList":
						instance.preFillSpriteList = reader.Read<System.Collections.Generic.List<UnityEngine.Sprite>>();
						break;
					case "useGUILayout":
						instance.useGUILayout = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "runInEditMode":
						instance.runInEditMode = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "enabled":
						instance.enabled = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "hideFlags":
						instance.hideFlags = reader.Read<UnityEngine.HideFlags>();
						break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}

	public class ES3Type_PlayMakerHashTableProxyArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3Type_PlayMakerHashTableProxyArray() : base(typeof(PlayMakerHashTableProxy[]), ES3Type_PlayMakerHashTableProxy.Instance)
		{
			Instance = this;
		}
	}
}