using System;
using System.IO;
using Cassini.FitocracyAnalyzer.Core.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cassini.FitocracyAnalyzer.Core
{
	public class FitocracyIO
	{
		readonly string fitoFolder;

		public FitocracyIO ()
		{
			var appDataFolder = Environment.GetFolderPath (Environment.SpecialFolder.LocalApplicationData);
			fitoFolder = Path.Combine (appDataFolder, "fitocracy");

			if (!Directory.Exists (fitoFolder))
				Directory.CreateDirectory (fitoFolder);
			JsonConvert.DefaultSettings = (() =>
				{
					var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore};
					settings.Converters.Add(new StringEnumConverter ());
					return settings;
				});
		}

		public string SaveWorkout (Workout workout)
		{
			var filePath = Path.Combine (fitoFolder, workout.Id.ToString ());
			using (var fileFd = new JsonTextWriter (new StreamWriter (filePath))) {
				fileFd.WriteRaw (JsonConvert.SerializeObject(workout, Formatting.Indented));
			}
			return filePath;
		}
	}
}

