﻿// <auto-generated />
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata;
using Oracle.EntityFrameworkCore.Metadata;
using esquire.Models.Fusion;

#pragma warning disable 219, 612, 618
#nullable enable

namespace esquire.Models.Compiled
{
    internal partial class AsePermissionVlEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "esquire.Models.Fusion.AsePermissionVl",
                typeof(AsePermissionVl),
                baseEntityType);

            var action = runtimeEntityType.AddProperty(
                "Action",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("Action", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<Action>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            action.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            action.AddAnnotation("Relational:ColumnName", "ACTION");

            var actionDelimiter = runtimeEntityType.AddProperty(
                "ActionDelimiter",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("ActionDelimiter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<ActionDelimiter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            actionDelimiter.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            actionDelimiter.AddAnnotation("Relational:ColumnName", "ACTION_DELIMITER");

            var appId = runtimeEntityType.AddProperty(
                "AppId",
                typeof(decimal?),
                propertyInfo: typeof(AsePermissionVl).GetProperty("AppId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<AppId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            appId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            appId.AddAnnotation("Relational:ColumnName", "APP_ID");
            appId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var code = runtimeEntityType.AddProperty(
                "Code",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("Code", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<Code>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 550,
                unicode: false);
            code.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            code.AddAnnotation("Relational:ColumnName", "CODE");

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            createdBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            createdBy.AddAnnotation("Relational:ColumnName", "CREATED_BY");

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(AsePermissionVl).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            creationDate.AddAnnotation("Relational:ColumnName", "CREATION_DATE");
            creationDate.AddAnnotation("Relational:ColumnType", "DATE");

            var dataSyncId = runtimeEntityType.AddProperty(
                "DataSyncId",
                typeof(decimal?),
                propertyInfo: typeof(AsePermissionVl).GetProperty("DataSyncId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<DataSyncId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            dataSyncId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            dataSyncId.AddAnnotation("Relational:ColumnName", "DATA_SYNC_ID");
            dataSyncId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 400,
                unicode: false);
            description.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            description.AddAnnotation("Relational:ColumnName", "DESCRIPTION");

            var effectiveEndDate = runtimeEntityType.AddProperty(
                "EffectiveEndDate",
                typeof(DateTime?),
                propertyInfo: typeof(AsePermissionVl).GetProperty("EffectiveEndDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<EffectiveEndDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            effectiveEndDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            effectiveEndDate.AddAnnotation("Relational:ColumnName", "EFFECTIVE_END_DATE");
            effectiveEndDate.AddAnnotation("Relational:ColumnType", "DATE");

            var effectiveStartDate = runtimeEntityType.AddProperty(
                "EffectiveStartDate",
                typeof(DateTime?),
                propertyInfo: typeof(AsePermissionVl).GetProperty("EffectiveStartDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<EffectiveStartDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            effectiveStartDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            effectiveStartDate.AddAnnotation("Relational:ColumnName", "EFFECTIVE_START_DATE");
            effectiveStartDate.AddAnnotation("Relational:ColumnType", "DATE");

            var language = runtimeEntityType.AddProperty(
                "Language",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("Language", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<Language>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            language.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            language.AddAnnotation("Relational:ColumnName", "LANGUAGE");

            var lastUpdateDate = runtimeEntityType.AddProperty(
                "LastUpdateDate",
                typeof(DateTime?),
                propertyInfo: typeof(AsePermissionVl).GetProperty("LastUpdateDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<LastUpdateDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastUpdateDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateDate.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_DATE");
            lastUpdateDate.AddAnnotation("Relational:ColumnType", "DATE");

            var lastUpdateLogin = runtimeEntityType.AddProperty(
                "LastUpdateLogin",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("LastUpdateLogin", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<LastUpdateLogin>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdateLogin.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateLogin.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_LOGIN");

            var lastUpdatedBy = runtimeEntityType.AddProperty(
                "LastUpdatedBy",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("LastUpdatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<LastUpdatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdatedBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdatedBy.AddAnnotation("Relational:ColumnName", "LAST_UPDATED_BY");

            var name = runtimeEntityType.AddProperty(
                "Name",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("Name", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<Name>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 250,
                unicode: false);
            name.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            name.AddAnnotation("Relational:ColumnName", "NAME");

            var objectVersionNumber = runtimeEntityType.AddProperty(
                "ObjectVersionNumber",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("ObjectVersionNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<ObjectVersionNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            objectVersionNumber.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            objectVersionNumber.AddAnnotation("Relational:ColumnName", "OBJECT_VERSION_NUMBER");

            var permissionId = runtimeEntityType.AddProperty(
                "PermissionId",
                typeof(decimal?),
                propertyInfo: typeof(AsePermissionVl).GetProperty("PermissionId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<PermissionId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            permissionId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            permissionId.AddAnnotation("Relational:ColumnName", "PERMISSION_ID");
            permissionId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var privilegeId = runtimeEntityType.AddProperty(
                "PrivilegeId",
                typeof(decimal?),
                propertyInfo: typeof(AsePermissionVl).GetProperty("PrivilegeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<PrivilegeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            privilegeId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            privilegeId.AddAnnotation("Relational:ColumnName", "PRIVILEGE_ID");
            privilegeId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var resourceTypeName = runtimeEntityType.AddProperty(
                "ResourceTypeName",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("ResourceTypeName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<ResourceTypeName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            resourceTypeName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            resourceTypeName.AddAnnotation("Relational:ColumnName", "RESOURCE_TYPE_NAME");

            var sourceLang = runtimeEntityType.AddProperty(
                "SourceLang",
                typeof(string),
                propertyInfo: typeof(AsePermissionVl).GetProperty("SourceLang", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AsePermissionVl).GetField("<SourceLang>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            sourceLang.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            sourceLang.AddAnnotation("Relational:ColumnName", "SOURCE_LANG");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "FUSION");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ASE_PERMISSION_VL");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}