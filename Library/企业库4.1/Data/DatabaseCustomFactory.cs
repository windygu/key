﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Data Access Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;
using Microsoft.Practices.EnterpriseLibrary.Data.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data.Properties;
using Microsoft.Practices.ObjectBuilder2;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Data
{
    /// <summary>
    /// This type supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
    /// Represents the process to build a <see cref="Database"/> described by configuration information.
    /// </summary>
    public class DatabaseCustomFactory : ICustomFactory
    {
        private IDictionary<Type, IDatabaseAssembler> assemblersMapping = new Dictionary<Type, IDatabaseAssembler>(5);
        private object assemblersMappingLock = new object();

        /// <summary>
        /// This method supports the Enterprise Library infrastructure and is not intended to be used directly from your code.
        /// Returns an <see cref="IDatabaseAssembler"/> that represents the building process for a a concrete <see cref="Database"/>.
        /// </summary>
        /// <param name="type">The concrete <see cref="Database"/> type.</param>
        /// <param name="name">The name of the instance to build, or <see langword="null"/> (<b>Nothing</b> in Visual Basic).</param>
        /// <param name="reflectionCache">The cache to use retrieving reflection information.</param>
        /// <returns>The <see cref="IDatabaseAssembler"/> instance.</returns>
        /// <exception cref="InvalidOperationException">when concrete <see cref="Database"/> type does have the required <see cref="DatabaseAssemblerAttribute"/>.</exception>
        public IDatabaseAssembler GetAssembler(Type type, string name, ConfigurationReflectionCache reflectionCache)
        {
            bool exists = false;
            IDatabaseAssembler assembler;
            lock (assemblersMappingLock)
            {
                exists = assemblersMapping.TryGetValue(type, out assembler);
            }
            if (!exists)
            {
                DatabaseAssemblerAttribute assemblerAttribute
                    = reflectionCache.GetCustomAttribute<DatabaseAssemblerAttribute>(type);
                if (assemblerAttribute == null)
                    throw new InvalidOperationException(
                        string.Format(
                            Resources.Culture,
                            Resources.ExceptionDatabaseTypeDoesNotHaveAssemblerAttribute,
                            type.FullName,
                            name));

                assembler
                    = (IDatabaseAssembler)Activator.CreateInstance(assemblerAttribute.AssemblerType);

                lock (assemblersMappingLock)
                {
                    assemblersMapping[type] = assembler;
                }
            }

            return assembler;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="name"></param>
        /// <param name="configurationSource"></param>
        /// <param name="reflectionCache"></param>
        /// <returns></returns>
        public object CreateObject(IBuilderContext context, string name, IConfigurationSource configurationSource, ConfigurationReflectionCache reflectionCache)
        {
            DatabaseConfigurationView configurationView = new DatabaseConfigurationView(configurationSource);
            ConnectionStringSettings connectionStringSettings = configurationView.GetConnectionStringSettings(name);
            DbProviderMapping mapping = configurationView.GetProviderMapping(name, connectionStringSettings.ProviderName);

            IDatabaseAssembler assembler = GetAssembler(mapping.DatabaseType, name, reflectionCache);
            Database database = assembler.Assemble(name, connectionStringSettings, configurationSource);

            return database;
        }
    }
}
