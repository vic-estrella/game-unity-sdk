using MirageSDK.Plugins.WalletConnectSharp.Core.Models;
using Newtonsoft.Json;
using UnityEngine;

namespace MirageSDK.Plugins.WalletConnectSharp.Unity.Utils
{
	public static class SessionSaveHandler
	{
		private const string SessionKey = "__WALLETCONNECT_SESSION__";

		public static SavedSession GetSavedSession()
		{
			if (!IsSessionSaved())
			{
				return null;
			}

			var json = PlayerPrefs.GetString(SessionKey);
			return JsonConvert.DeserializeObject<SavedSession>(json);
		}

		public static bool IsSessionSaved()
		{
			return PlayerPrefs.HasKey(SessionKey);
		}

		public static void SaveSession(SavedSession sessionToSave)
		{
			var json = JsonConvert.SerializeObject(sessionToSave);
			PlayerPrefs.SetString(SessionKey, json);
		}

		public static void ClearSession()
		{
			PlayerPrefs.DeleteKey(SessionKey);
		}
	}
}