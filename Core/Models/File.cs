// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2015 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Models 
{
	public class File : Item 
	{

		/// <summary>
		/// Represents the Object Storage Identifier for this File. This field is
		/// used in Object Storage providers - including sharefile.com and Storage Zones. Other
		/// providers like CIFS and SharePoint do not need external references for object
		/// blobs and do not populate this field.
		/// </summary>
		public string FilePath { get; set; }

		/// <summary>
		/// MD5 Hash of the File contents.
		/// </summary>
		public string Hash { get; set; }

		/// <summary>
		/// Indicates that the File has an image Preview.
		/// </summary>
		public bool? HasPreview { get; set; }

		/// <summary>
		/// Current Anti-Virus scanning status for this file
		/// </summary>
		public SafeEnum<FileVirusStatus> VirusStatus { get; set; }

		/// <summary>
		/// Indicates the user that has locked the file
		/// </summary>
		public User LockedBy { get; set; }

		/// <summary>
		/// File lock info
		/// </summary>
		public FileLock FileLockInfo { get; set; }

		/// <summary>
		/// File version.
		/// </summary>
		public float? Version { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as File;
			if(typedSource != null)
			{
				FilePath = typedSource.FilePath;
				Hash = typedSource.Hash;
				HasPreview = typedSource.HasPreview;
				VirusStatus = typedSource.VirusStatus;
				LockedBy = typedSource.LockedBy;
				FileLockInfo = typedSource.FileLockInfo;
				Version = typedSource.Version;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("FilePath", out token) && token.Type != JTokenType.Null)
				{
					FilePath = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Hash", out token) && token.Type != JTokenType.Null)
				{
					Hash = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("HasPreview", out token) && token.Type != JTokenType.Null)
				{
					HasPreview = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("VirusStatus", out token) && token.Type != JTokenType.Null)
				{
					VirusStatus = (SafeEnum<FileVirusStatus>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<FileVirusStatus>));
				}
				if(source.TryGetProperty("LockedBy", out token) && token.Type != JTokenType.Null)
				{
					LockedBy = (User)serializer.Deserialize(token.CreateReader(), typeof(User));
				}
				if(source.TryGetProperty("FileLockInfo", out token) && token.Type != JTokenType.Null)
				{
					FileLockInfo = (FileLock)serializer.Deserialize(token.CreateReader(), typeof(FileLock));
				}
				if(source.TryGetProperty("Version", out token) && token.Type != JTokenType.Null)
				{
					Version = (float?)serializer.Deserialize(token.CreateReader(), typeof(float?));
				}
			}
		}
	}
}