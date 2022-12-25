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
    internal partial class FunUserRoleDataAsgnmntEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "esquire.Models.Fusion.FunUserRoleDataAsgnmnt",
                typeof(FunUserRoleDataAsgnmnt),
                baseEntityType);

            var accessSetId = runtimeEntityType.AddProperty(
                "AccessSetId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("AccessSetId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<AccessSetId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            accessSetId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            accessSetId.AddAnnotation("Relational:ColumnName", "ACCESS_SET_ID");
            accessSetId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var activeFlag = runtimeEntityType.AddProperty(
                "ActiveFlag",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("ActiveFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<ActiveFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            activeFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            activeFlag.AddAnnotation("Relational:ColumnName", "ACTIVE_FLAG");

            var bookId = runtimeEntityType.AddProperty(
                "BookId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("BookId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<BookId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            bookId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            bookId.AddAnnotation("Relational:ColumnName", "BOOK_ID");
            bookId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var collaborationDocId = runtimeEntityType.AddProperty(
                "CollaborationDocId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("CollaborationDocId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<CollaborationDocId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            collaborationDocId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            collaborationDocId.AddAnnotation("Relational:ColumnName", "COLLABORATION_DOC_ID");
            collaborationDocId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var controlBudgetId = runtimeEntityType.AddProperty(
                "ControlBudgetId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("ControlBudgetId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<ControlBudgetId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            controlBudgetId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            controlBudgetId.AddAnnotation("Relational:ColumnName", "CONTROL_BUDGET_ID");
            controlBudgetId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            createdBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            createdBy.AddAnnotation("Relational:ColumnName", "CREATED_BY");

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            creationDate.AddAnnotation("Relational:ColumnName", "CREATION_DATE");
            creationDate.AddAnnotation("Relational:ColumnType", "DATE");

            var cstOrganizationId = runtimeEntityType.AddProperty(
                "CstOrganizationId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("CstOrganizationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<CstOrganizationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            cstOrganizationId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            cstOrganizationId.AddAnnotation("Relational:ColumnName", "CST_ORGANIZATION_ID");
            cstOrganizationId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var datasecContextTypeCode = runtimeEntityType.AddProperty(
                "DatasecContextTypeCode",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("DatasecContextTypeCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<DatasecContextTypeCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            datasecContextTypeCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            datasecContextTypeCode.AddAnnotation("Relational:ColumnName", "DATASEC_CONTEXT_TYPE_CODE");

            var datasecContextValue1 = runtimeEntityType.AddProperty(
                "DatasecContextValue1",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("DatasecContextValue1", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<DatasecContextValue1>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            datasecContextValue1.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            datasecContextValue1.AddAnnotation("Relational:ColumnName", "DATASEC_CONTEXT_VALUE1");

            var datasecContextValue2 = runtimeEntityType.AddProperty(
                "DatasecContextValue2",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("DatasecContextValue2", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<DatasecContextValue2>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            datasecContextValue2.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            datasecContextValue2.AddAnnotation("Relational:ColumnName", "DATASEC_CONTEXT_VALUE2");

            var datasecContextValue3 = runtimeEntityType.AddProperty(
                "DatasecContextValue3",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("DatasecContextValue3", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<DatasecContextValue3>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            datasecContextValue3.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            datasecContextValue3.AddAnnotation("Relational:ColumnName", "DATASEC_CONTEXT_VALUE3");

            var datasecContextValue4 = runtimeEntityType.AddProperty(
                "DatasecContextValue4",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("DatasecContextValue4", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<DatasecContextValue4>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            datasecContextValue4.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            datasecContextValue4.AddAnnotation("Relational:ColumnName", "DATASEC_CONTEXT_VALUE4");

            var datasecContextValue5 = runtimeEntityType.AddProperty(
                "DatasecContextValue5",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("DatasecContextValue5", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<DatasecContextValue5>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            datasecContextValue5.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            datasecContextValue5.AddAnnotation("Relational:ColumnName", "DATASEC_CONTEXT_VALUE5");

            var endDateActive = runtimeEntityType.AddProperty(
                "EndDateActive",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("EndDateActive", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<EndDateActive>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            endDateActive.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            endDateActive.AddAnnotation("Relational:ColumnName", "END_DATE_ACTIVE");

            var enterpriseId = runtimeEntityType.AddProperty(
                "EnterpriseId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("EnterpriseId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<EnterpriseId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            enterpriseId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            enterpriseId.AddAnnotation("Relational:ColumnName", "ENTERPRISE_ID");
            enterpriseId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var intercoOrgId = runtimeEntityType.AddProperty(
                "IntercoOrgId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("IntercoOrgId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<IntercoOrgId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            intercoOrgId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            intercoOrgId.AddAnnotation("Relational:ColumnName", "INTERCO_ORG_ID");
            intercoOrgId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var invOrganizationId = runtimeEntityType.AddProperty(
                "InvOrganizationId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("InvOrganizationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<InvOrganizationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            invOrganizationId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            invOrganizationId.AddAnnotation("Relational:ColumnName", "INV_ORGANIZATION_ID");
            invOrganizationId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var itmOrganizationId = runtimeEntityType.AddProperty(
                "ItmOrganizationId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("ItmOrganizationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<ItmOrganizationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            itmOrganizationId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            itmOrganizationId.AddAnnotation("Relational:ColumnName", "ITM_ORGANIZATION_ID");
            itmOrganizationId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var lastUpdateDate = runtimeEntityType.AddProperty(
                "LastUpdateDate",
                typeof(DateTime?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("LastUpdateDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<LastUpdateDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastUpdateDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateDate.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_DATE");
            lastUpdateDate.AddAnnotation("Relational:ColumnType", "DATE");

            var lastUpdateLogin = runtimeEntityType.AddProperty(
                "LastUpdateLogin",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("LastUpdateLogin", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<LastUpdateLogin>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdateLogin.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateLogin.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_LOGIN");

            var lastUpdatedBy = runtimeEntityType.AddProperty(
                "LastUpdatedBy",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("LastUpdatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<LastUpdatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdatedBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdatedBy.AddAnnotation("Relational:ColumnName", "LAST_UPDATED_BY");

            var ledgerId = runtimeEntityType.AddProperty(
                "LedgerId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("LedgerId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<LedgerId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            ledgerId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            ledgerId.AddAnnotation("Relational:ColumnName", "LEDGER_ID");
            ledgerId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var mfgOrganizationId = runtimeEntityType.AddProperty(
                "MfgOrganizationId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("MfgOrganizationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<MfgOrganizationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            mfgOrganizationId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            mfgOrganizationId.AddAnnotation("Relational:ColumnName", "MFG_ORGANIZATION_ID");
            mfgOrganizationId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var objectVersionNumber = runtimeEntityType.AddProperty(
                "ObjectVersionNumber",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("ObjectVersionNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<ObjectVersionNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            objectVersionNumber.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            objectVersionNumber.AddAnnotation("Relational:ColumnName", "OBJECT_VERSION_NUMBER");
            objectVersionNumber.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var orgId = runtimeEntityType.AddProperty(
                "OrgId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("OrgId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<OrgId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            orgId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            orgId.AddAnnotation("Relational:ColumnName", "ORG_ID");
            orgId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var prjOrganizationId = runtimeEntityType.AddProperty(
                "PrjOrganizationId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("PrjOrganizationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<PrjOrganizationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            prjOrganizationId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            prjOrganizationId.AddAnnotation("Relational:ColumnName", "PRJ_ORGANIZATION_ID");
            prjOrganizationId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var recordTypeCode = runtimeEntityType.AddProperty(
                "RecordTypeCode",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("RecordTypeCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<RecordTypeCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            recordTypeCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            recordTypeCode.AddAnnotation("Relational:ColumnName", "RECORD_TYPE_CODE");

            var roleName = runtimeEntityType.AddProperty(
                "RoleName",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("RoleName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<RoleName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            roleName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            roleName.AddAnnotation("Relational:ColumnName", "ROLE_NAME");

            var setId = runtimeEntityType.AddProperty(
                "SetId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("SetId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<SetId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            setId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            setId.AddAnnotation("Relational:ColumnName", "SET_ID");
            setId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var startDateActive = runtimeEntityType.AddProperty(
                "StartDateActive",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("StartDateActive", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<StartDateActive>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            startDateActive.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            startDateActive.AddAnnotation("Relational:ColumnName", "START_DATE_ACTIVE");

            var userGuid = runtimeEntityType.AddProperty(
                "UserGuid",
                typeof(string),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("UserGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<UserGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            userGuid.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            userGuid.AddAnnotation("Relational:ColumnName", "USER_GUID");

            var userRoleDataAssignmentId = runtimeEntityType.AddProperty(
                "UserRoleDataAssignmentId",
                typeof(decimal?),
                propertyInfo: typeof(FunUserRoleDataAsgnmnt).GetProperty("UserRoleDataAssignmentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FunUserRoleDataAsgnmnt).GetField("<UserRoleDataAssignmentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            userRoleDataAssignmentId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            userRoleDataAssignmentId.AddAnnotation("Relational:ColumnName", "USER_ROLE_DATA_ASSIGNMENT_ID");
            userRoleDataAssignmentId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "FUSION");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "FUN_USER_ROLE_DATA_ASGNMNTS");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}