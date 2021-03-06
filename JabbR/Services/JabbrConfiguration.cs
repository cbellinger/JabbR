﻿using System;
using System.Configuration;

namespace JabbR.Services
{
    public class JabbrConfiguration : IJabbrConfiguration
    {
        public bool RequireHttps
        {
            get
            {
                string requireHttpsValue = ConfigurationManager.AppSettings["jabbr:requireHttps"];
                bool requireHttps;
                if (Boolean.TryParse(requireHttpsValue, out requireHttps))
                {
                    return requireHttps;
                }
                return false;
            }
        }

        public bool ProxyImages
        {
            get
            {
                string proxyImagesValue = ConfigurationManager.AppSettings["jabbr:proxyImages"];
                bool proxyImages;
                if (Boolean.TryParse(proxyImagesValue, out proxyImages))
                {
                    return proxyImages;
                }
                return false;
            }
        }

        public bool MigrateDatabase
        {
            get
            {
                string migrateDatabaseValue = ConfigurationManager.AppSettings["jabbr:migrateDatabase"];
                bool migrateDatabase;
                if (Boolean.TryParse(migrateDatabaseValue, out migrateDatabase))
                {
                    return migrateDatabase;
                }
                return false;
            }
        }

        public string DeploymentSha
        {
            get
            {
                return ConfigurationManager.AppSettings["jabbr:releaseSha"];
            }
        }

        public string DeploymentBranch
        {
            get
            {
                return ConfigurationManager.AppSettings["jabbr:releaseBranch"];
            }
        }

        public string DeploymentTime
        {
            get
            {
                return ConfigurationManager.AppSettings["jabbr:releaseTime"];
            }
        }

        public string DefaultAdminUserName
        {
            get
            {
                return ConfigurationManager.AppSettings["jabbr:defaultAdminUserName"];
            }
        }

        public string DefaultAdminPassword
        {
            get
            {
                return ConfigurationManager.AppSettings["jabbr:defaultAdminPassword"];
            }
        }

        public string ServiceBusConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["jabbr:serviceBusConnectionString"];
            }
        }

        public string ServiceBusTopicPrefix
        {
            get
            {
                return ConfigurationManager.AppSettings["jabbr:serviceBusTopicPrefix"];
            }
        }

        public bool ScaleOutSqlServer
        {
            get
            {
                string scaleOutSqlServerValue = ConfigurationManager.AppSettings["jabbr:scaleOutSqlServer"];
                bool scaleOutSqlServer;
                if (Boolean.TryParse(scaleOutSqlServerValue, out scaleOutSqlServer))
                {
                    return scaleOutSqlServer;
                }
                return false;
            }
        }

        public ConnectionStringSettings SqlConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Jabbr"];
            }
        }
    }
}