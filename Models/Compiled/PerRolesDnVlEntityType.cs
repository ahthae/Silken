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
    internal partial class PerRolesDnVlEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "esquire.Models.Fusion.PerRolesDnVl",
                typeof(PerRolesDnVl),
                baseEntityType);

            var abstractRole = runtimeEntityType.AddProperty(
                "AbstractRole",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("AbstractRole", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<AbstractRole>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            abstractRole.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            abstractRole.AddAnnotation("Relational:ColumnName", "ABSTRACT_ROLE");

            var activeFlag = runtimeEntityType.AddProperty(
                "ActiveFlag",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("ActiveFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<ActiveFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            activeFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            activeFlag.AddAnnotation("Relational:ColumnName", "ACTIVE_FLAG");

            var businessGroupId = runtimeEntityType.AddProperty(
                "BusinessGroupId",
                typeof(decimal?),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("BusinessGroupId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<BusinessGroupId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            businessGroupId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            businessGroupId.AddAnnotation("Relational:ColumnName", "BUSINESS_GROUP_ID");
            businessGroupId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            createdBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            createdBy.AddAnnotation("Relational:ColumnName", "CREATED_BY");

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            creationDate.AddAnnotation("Relational:ColumnName", "CREATION_DATE");
            creationDate.AddAnnotation("Relational:ColumnType", "DATE");

            var dataRole = runtimeEntityType.AddProperty(
                "DataRole",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("DataRole", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<DataRole>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            dataRole.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            dataRole.AddAnnotation("Relational:ColumnName", "DATA_ROLE");

            var delegationAllowed = runtimeEntityType.AddProperty(
                "DelegationAllowed",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("DelegationAllowed", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<DelegationAllowed>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            delegationAllowed.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            delegationAllowed.AddAnnotation("Relational:ColumnName", "DELEGATION_ALLOWED");

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 800,
                unicode: false);
            description.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            description.AddAnnotation("Relational:ColumnName", "DESCRIPTION");

            var dutyRole = runtimeEntityType.AddProperty(
                "DutyRole",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("DutyRole", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<DutyRole>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            dutyRole.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            dutyRole.AddAnnotation("Relational:ColumnName", "DUTY_ROLE");

            var externalId = runtimeEntityType.AddProperty(
                "ExternalId",
                typeof(decimal?),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("ExternalId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<ExternalId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            externalId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            externalId.AddAnnotation("Relational:ColumnName", "EXTERNAL_ID");
            externalId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var externalRole = runtimeEntityType.AddProperty(
                "ExternalRole",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("ExternalRole", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<ExternalRole>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            externalRole.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            externalRole.AddAnnotation("Relational:ColumnName", "EXTERNAL_ROLE");

            var jobRole = runtimeEntityType.AddProperty(
                "JobRole",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("JobRole", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<JobRole>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            jobRole.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            jobRole.AddAnnotation("Relational:ColumnName", "JOB_ROLE");

            var lastUpdateDate = runtimeEntityType.AddProperty(
                "LastUpdateDate",
                typeof(DateTime?),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("LastUpdateDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<LastUpdateDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastUpdateDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateDate.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_DATE");
            lastUpdateDate.AddAnnotation("Relational:ColumnType", "DATE");

            var lastUpdateLogin = runtimeEntityType.AddProperty(
                "LastUpdateLogin",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("LastUpdateLogin", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<LastUpdateLogin>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdateLogin.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateLogin.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_LOGIN");

            var lastUpdatedBy = runtimeEntityType.AddProperty(
                "LastUpdatedBy",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("LastUpdatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<LastUpdatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdatedBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdatedBy.AddAnnotation("Relational:ColumnName", "LAST_UPDATED_BY");

            var multitenancyCommonName = runtimeEntityType.AddProperty(
                "MultitenancyCommonName",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("MultitenancyCommonName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<MultitenancyCommonName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            multitenancyCommonName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            multitenancyCommonName.AddAnnotation("Relational:ColumnName", "MULTITENANCY_COMMON_NAME");

            var objectVersionNumber = runtimeEntityType.AddProperty(
                "ObjectVersionNumber",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("ObjectVersionNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<ObjectVersionNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            objectVersionNumber.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            objectVersionNumber.AddAnnotation("Relational:ColumnName", "OBJECT_VERSION_NUMBER");

            var roleCommonName = runtimeEntityType.AddProperty(
                "RoleCommonName",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("RoleCommonName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<RoleCommonName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            roleCommonName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            roleCommonName.AddAnnotation("Relational:ColumnName", "ROLE_COMMON_NAME");

            var roleDistinguishedName = runtimeEntityType.AddProperty(
                "RoleDistinguishedName",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("RoleDistinguishedName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<RoleDistinguishedName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200,
                unicode: false);
            roleDistinguishedName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            roleDistinguishedName.AddAnnotation("Relational:ColumnName", "ROLE_DISTINGUISHED_NAME");

            var roleGuid = runtimeEntityType.AddProperty(
                "RoleGuid",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("RoleGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<RoleGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            roleGuid.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            roleGuid.AddAnnotation("Relational:ColumnName", "ROLE_GUID");

            var roleId = runtimeEntityType.AddProperty(
                "RoleId",
                typeof(decimal?),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("RoleId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<RoleId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            roleId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            roleId.AddAnnotation("Relational:ColumnName", "ROLE_ID");
            roleId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var roleName = runtimeEntityType.AddProperty(
                "RoleName",
                typeof(string),
                propertyInfo: typeof(PerRolesDnVl).GetProperty("RoleName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerRolesDnVl).GetField("<RoleName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 150,
                unicode: false);
            roleName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            roleName.AddAnnotation("Relational:ColumnName", "ROLE_NAME");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "FUSION");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PER_ROLES_DN_VL");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}