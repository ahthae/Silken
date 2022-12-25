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
    internal partial class PerPositionSecurityProfileEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "esquire.Models.Fusion.PerPositionSecurityProfile",
                typeof(PerPositionSecurityProfile),
                baseEntityType);

            var buOrgSecurityProfileId = runtimeEntityType.AddProperty(
                "BuOrgSecurityProfileId",
                typeof(decimal?),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("BuOrgSecurityProfileId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<BuOrgSecurityProfileId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            buOrgSecurityProfileId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            buOrgSecurityProfileId.AddAnnotation("Relational:ColumnName", "BU_ORG_SECURITY_PROFILE_ID");
            buOrgSecurityProfileId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var businessGroupId = runtimeEntityType.AddProperty(
                "BusinessGroupId",
                typeof(decimal?),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("BusinessGroupId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<BusinessGroupId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            businessGroupId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            businessGroupId.AddAnnotation("Relational:ColumnName", "BUSINESS_GROUP_ID");
            businessGroupId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            createdBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            createdBy.AddAnnotation("Relational:ColumnName", "CREATED_BY");

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            creationDate.AddAnnotation("Relational:ColumnName", "CREATION_DATE");
            creationDate.AddAnnotation("Relational:ColumnType", "DATE");

            var deptOrgSecurityProfileId = runtimeEntityType.AddProperty(
                "DeptOrgSecurityProfileId",
                typeof(decimal?),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("DeptOrgSecurityProfileId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<DeptOrgSecurityProfileId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            deptOrgSecurityProfileId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            deptOrgSecurityProfileId.AddAnnotation("Relational:ColumnName", "DEPT_ORG_SECURITY_PROFILE_ID");
            deptOrgSecurityProfileId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            description.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            description.AddAnnotation("Relational:ColumnName", "DESCRIPTION");

            var enabledFlag = runtimeEntityType.AddProperty(
                "EnabledFlag",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("EnabledFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<EnabledFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            enabledFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            enabledFlag.AddAnnotation("Relational:ColumnName", "ENABLED_FLAG");

            var includeFuturePositions = runtimeEntityType.AddProperty(
                "IncludeFuturePositions",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("IncludeFuturePositions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<IncludeFuturePositions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            includeFuturePositions.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            includeFuturePositions.AddAnnotation("Relational:ColumnName", "INCLUDE_FUTURE_POSITIONS");

            var includeTopPosition = runtimeEntityType.AddProperty(
                "IncludeTopPosition",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("IncludeTopPosition", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<IncludeTopPosition>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            includeTopPosition.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            includeTopPosition.AddAnnotation("Relational:ColumnName", "INCLUDE_TOP_POSITION");

            var jobSecurityProfileId = runtimeEntityType.AddProperty(
                "JobSecurityProfileId",
                typeof(decimal?),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("JobSecurityProfileId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<JobSecurityProfileId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            jobSecurityProfileId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            jobSecurityProfileId.AddAnnotation("Relational:ColumnName", "JOB_SECURITY_PROFILE_ID");
            jobSecurityProfileId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var lastUpdateDate = runtimeEntityType.AddProperty(
                "LastUpdateDate",
                typeof(DateTime?),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("LastUpdateDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<LastUpdateDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastUpdateDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateDate.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_DATE");
            lastUpdateDate.AddAnnotation("Relational:ColumnType", "DATE");

            var lastUpdateLogin = runtimeEntityType.AddProperty(
                "LastUpdateLogin",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("LastUpdateLogin", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<LastUpdateLogin>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdateLogin.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateLogin.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_LOGIN");

            var lastUpdatedBy = runtimeEntityType.AddProperty(
                "LastUpdatedBy",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("LastUpdatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<LastUpdatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdatedBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdatedBy.AddAnnotation("Relational:ColumnName", "LAST_UPDATED_BY");

            var locSecurityProfileId = runtimeEntityType.AddProperty(
                "LocSecurityProfileId",
                typeof(decimal?),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("LocSecurityProfileId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<LocSecurityProfileId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            locSecurityProfileId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            locSecurityProfileId.AddAnnotation("Relational:ColumnName", "LOC_SECURITY_PROFILE_ID");
            locSecurityProfileId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var moduleId = runtimeEntityType.AddProperty(
                "ModuleId",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("ModuleId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<ModuleId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            moduleId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            moduleId.AddAnnotation("Relational:ColumnName", "MODULE_ID");

            var name = runtimeEntityType.AddProperty(
                "Name",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("Name", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<Name>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            name.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            name.AddAnnotation("Relational:ColumnName", "NAME");

            var objectVersionNumber = runtimeEntityType.AddProperty(
                "ObjectVersionNumber",
                typeof(decimal?),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("ObjectVersionNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<ObjectVersionNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            objectVersionNumber.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            objectVersionNumber.AddAnnotation("Relational:ColumnName", "OBJECT_VERSION_NUMBER");
            objectVersionNumber.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var posHierarchyTreeCode = runtimeEntityType.AddProperty(
                "PosHierarchyTreeCode",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("PosHierarchyTreeCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<PosHierarchyTreeCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            posHierarchyTreeCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            posHierarchyTreeCode.AddAnnotation("Relational:ColumnName", "POS_HIERARCHY_TREE_CODE");

            var posHierarchyTreeStructCode = runtimeEntityType.AddProperty(
                "PosHierarchyTreeStructCode",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("PosHierarchyTreeStructCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<PosHierarchyTreeStructCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            posHierarchyTreeStructCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            posHierarchyTreeStructCode.AddAnnotation("Relational:ColumnName", "POS_HIERARCHY_TREE_STRUCT_CODE");

            var positionSecurityProfileId = runtimeEntityType.AddProperty(
                "PositionSecurityProfileId",
                typeof(decimal?),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("PositionSecurityProfileId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<PositionSecurityProfileId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            positionSecurityProfileId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            positionSecurityProfileId.AddAnnotation("Relational:ColumnName", "POSITION_SECURITY_PROFILE_ID");
            positionSecurityProfileId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var secureByAor = runtimeEntityType.AddProperty(
                "SecureByAor",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("SecureByAor", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<SecureByAor>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            secureByAor.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            secureByAor.AddAnnotation("Relational:ColumnName", "SECURE_BY_AOR");

            var secureByBusinessUnit = runtimeEntityType.AddProperty(
                "SecureByBusinessUnit",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("SecureByBusinessUnit", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<SecureByBusinessUnit>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            secureByBusinessUnit.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            secureByBusinessUnit.AddAnnotation("Relational:ColumnName", "SECURE_BY_BUSINESS_UNIT");

            var secureByDepartment = runtimeEntityType.AddProperty(
                "SecureByDepartment",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("SecureByDepartment", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<SecureByDepartment>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            secureByDepartment.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            secureByDepartment.AddAnnotation("Relational:ColumnName", "SECURE_BY_DEPARTMENT");

            var secureByJob = runtimeEntityType.AddProperty(
                "SecureByJob",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("SecureByJob", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<SecureByJob>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            secureByJob.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            secureByJob.AddAnnotation("Relational:ColumnName", "SECURE_BY_JOB");

            var secureByLocation = runtimeEntityType.AddProperty(
                "SecureByLocation",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("SecureByLocation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<SecureByLocation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            secureByLocation.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            secureByLocation.AddAnnotation("Relational:ColumnName", "SECURE_BY_LOCATION");

            var secureByPositionHierarchy = runtimeEntityType.AddProperty(
                "SecureByPositionHierarchy",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("SecureByPositionHierarchy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<SecureByPositionHierarchy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            secureByPositionHierarchy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            secureByPositionHierarchy.AddAnnotation("Relational:ColumnName", "SECURE_BY_POSITION_HIERARCHY");

            var secureByPositionList = runtimeEntityType.AddProperty(
                "SecureByPositionList",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("SecureByPositionList", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<SecureByPositionList>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            secureByPositionList.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            secureByPositionList.AddAnnotation("Relational:ColumnName", "SECURE_BY_POSITION_LIST");

            var seedDataSource = runtimeEntityType.AddProperty(
                "SeedDataSource",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("SeedDataSource", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<SeedDataSource>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            seedDataSource.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            seedDataSource.AddAnnotation("Relational:ColumnName", "SEED_DATA_SOURCE");

            var sguid = runtimeEntityType.AddProperty(
                "Sguid",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("Sguid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<Sguid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            sguid.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            sguid.AddAnnotation("Relational:ColumnName", "SGUID");

            var topPosSelection = runtimeEntityType.AddProperty(
                "TopPosSelection",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("TopPosSelection", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<TopPosSelection>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            topPosSelection.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            topPosSelection.AddAnnotation("Relational:ColumnName", "TOP_POS_SELECTION");

            var topPositionId = runtimeEntityType.AddProperty(
                "TopPositionId",
                typeof(decimal?),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("TopPositionId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<TopPositionId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            topPositionId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            topPositionId.AddAnnotation("Relational:ColumnName", "TOP_POSITION_ID");
            topPositionId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var viewAll = runtimeEntityType.AddProperty(
                "ViewAll",
                typeof(string),
                propertyInfo: typeof(PerPositionSecurityProfile).GetProperty("ViewAll", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PerPositionSecurityProfile).GetField("<ViewAll>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            viewAll.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            viewAll.AddAnnotation("Relational:ColumnName", "VIEW_ALL");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "FUSION");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PER_POSITION_SECURITY_PROFILES");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}