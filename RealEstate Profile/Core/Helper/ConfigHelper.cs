﻿using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace RealEstate_Profile.Core.Helper
{
    #region -- Configuration Class --
    /// <summary>
    /// This Configuration class is basically just a set of 
    /// properties with a couple of static methods to manage
    /// the serialization to and deserialization from a
    /// simple XML file.
    /// </summary>
    [Serializable]
    public class ConfigHelper
    {
        public static string ConfigFileName => "BTIConnectionCFG.config";
        public static string ReadPath => string.Concat(Application.StartupPath, "\\", ConfigFileName);
        public static string WebConfigRead(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[key] ?? "Not Found";
            return result;
        }
        public static void WebConfigWrite(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
            finally
            {

            }
        }

        public static string ConnectionStringSql()
        {
            string connectionString = string.Empty;
            try
            {
                var config = DeserializeDatabaseConfiguration(ReadPath);
                if (config != null)
                {
                    connectionString = string.Concat(@"data source=", config.ServerName, ";initial catalog=",
                        config.DatabaseName, ";user id=", config.DbUserName, ";password=", config.DbPassword,
                        ";MultipleActiveResultSets=True;App=EntityFramework providerName=System.Data.SqlClient");
                }
            }
            catch (Exception e)
            {
                //LogHelper.Log(string.Concat(LogHelper.LogType.Error.ToLogType(), " ", typeof(ConfigHelper), " ", MethodBase.GetCurrentMethod().Name, e.Message));
            }


            return connectionString;
        }

        public static string ConnectionStringOleDb()
        {
            string connectionString = string.Empty;
            try
            {
                var config = DeserializeDatabaseConfiguration(ReadPath);
                if (config != null)
                {
                    connectionString = string.Concat(@"Provider=Microsoft.ACE.OLEDB.12.0;data source=", config.ServerName, ";initial catalog=",
                        config.DatabaseName, ";user id=", config.DbUserName, ";password=", config.DbPassword,
                        ";MultipleActiveResultSets=True;App=EntityFramework providerName=System.Data.SqlClient");
                }
            }
            catch (Exception e)
            {
                //LogHelper.Log(string.Concat(LogHelper.LogType.Error.ToLogType(), " ", typeof(ConfigHelper), " ", MethodBase.GetCurrentMethod().Name, e.Message));
            }


            return connectionString;
        }

        //#region Serialize - Deserialize Operation

        //public static string SerializeDatabaseConfiguration(string file, ConfigSettings settings)
        //{
        //    var result = string.Empty;
        //    try
        //    {
        //        FileIOPermission perm = new FileIOPermission(FileIOPermissionAccess.Write, file);
        //        perm.Demand();
        //        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
        //        ns.Add(string.Empty, string.Empty);
        //        var xs = new System.Xml.Serialization.XmlSerializer(settings.GetType());
        //        var writer = File.CreateText(string.Concat(file, ConfigFileName));
        //        xs.Serialize(writer, settings, ns);
        //        writer.Flush();
        //        writer.Close();
        //        result = "OK";
        //    }
        //    catch (Exception e)
        //    {
        //        result = e.Message;
        //        //Logger.LogError(e.Message);
        //    }
        //    return result;
        //}
        //public static string SerializeDatabaseConfiguration(string file, object settings)
        //{
        //    var result = string.Empty;
        //    try
        //    {
        //        var xs = new System.Xml.Serialization.XmlSerializer(settings.GetType());
        //        var writer = File.CreateText(string.Concat(file, "\\", ConfigFileName));
        //        xs.Serialize(writer, settings);
        //        writer.Flush();
        //        writer.Close();
        //        result = "OK";
        //    }
        //    catch (Exception e)
        //    {
        //        result = e.Message;
        //    }
        //    return result;
        //}
        public static ConfigSettings DeserializeDatabaseConfiguration(string file)
        {
            ConfigSettings c = null;
            if (File.Exists(file))
            {
                var xs = new XmlSerializer(
                    typeof(ConfigSettings));
                var reader = File.OpenText(file);
                c = (ConfigSettings)xs.Deserialize(reader);
                reader.Close();

            }
            return c;
        }
        public static T DeserializeXml<T>(string file)
        {
            var c = Activator.CreateInstance(typeof(T));
            if (File.Exists(file))
            {
                var xs = new XmlSerializer(typeof(T));
                //var reader = File.OpenText(file);
                var reader = new StreamReader(file, Encoding.UTF8);
                c = (T)xs.Deserialize(reader);
                reader.Close();

            }
            return (T)c;
        }
        #endregion

    }

}
