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
    internal partial class GlAccessSetEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "esquire.Models.Fusion.GlAccessSet",
                typeof(GlAccessSet),
                baseEntityType);

            var accessSetId = runtimeEntityType.AddProperty(
                "AccessSetId",
                typeof(decimal?),
                propertyInfo: typeof(GlAccessSet).GetProperty("AccessSetId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<AccessSetId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            accessSetId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            accessSetId.AddAnnotation("Relational:ColumnName", "ACCESS_SET_ID");
            accessSetId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var accountedPeriodType = runtimeEntityType.AddProperty(
                "AccountedPeriodType",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("AccountedPeriodType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<AccountedPeriodType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            accountedPeriodType.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            accountedPeriodType.AddAnnotation("Relational:ColumnName", "ACCOUNTED_PERIOD_TYPE");

            var attribute1 = runtimeEntityType.AddProperty(
                "Attribute1",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute1", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute1>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute1.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute1.AddAnnotation("Relational:ColumnName", "ATTRIBUTE1");

            var attribute10 = runtimeEntityType.AddProperty(
                "Attribute10",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute10", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute10>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute10.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute10.AddAnnotation("Relational:ColumnName", "ATTRIBUTE10");

            var attribute11 = runtimeEntityType.AddProperty(
                "Attribute11",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute11", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute11>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute11.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute11.AddAnnotation("Relational:ColumnName", "ATTRIBUTE11");

            var attribute12 = runtimeEntityType.AddProperty(
                "Attribute12",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute12", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute12>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute12.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute12.AddAnnotation("Relational:ColumnName", "ATTRIBUTE12");

            var attribute13 = runtimeEntityType.AddProperty(
                "Attribute13",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute13", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute13>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute13.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute13.AddAnnotation("Relational:ColumnName", "ATTRIBUTE13");

            var attribute14 = runtimeEntityType.AddProperty(
                "Attribute14",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute14", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute14>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute14.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute14.AddAnnotation("Relational:ColumnName", "ATTRIBUTE14");

            var attribute15 = runtimeEntityType.AddProperty(
                "Attribute15",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute15", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute15>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute15.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute15.AddAnnotation("Relational:ColumnName", "ATTRIBUTE15");

            var attribute2 = runtimeEntityType.AddProperty(
                "Attribute2",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute2", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute2>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute2.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute2.AddAnnotation("Relational:ColumnName", "ATTRIBUTE2");

            var attribute3 = runtimeEntityType.AddProperty(
                "Attribute3",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute3", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute3>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute3.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute3.AddAnnotation("Relational:ColumnName", "ATTRIBUTE3");

            var attribute4 = runtimeEntityType.AddProperty(
                "Attribute4",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute4", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute4>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute4.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute4.AddAnnotation("Relational:ColumnName", "ATTRIBUTE4");

            var attribute5 = runtimeEntityType.AddProperty(
                "Attribute5",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute5", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute5>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute5.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute5.AddAnnotation("Relational:ColumnName", "ATTRIBUTE5");

            var attribute6 = runtimeEntityType.AddProperty(
                "Attribute6",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute6", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute6>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute6.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute6.AddAnnotation("Relational:ColumnName", "ATTRIBUTE6");

            var attribute7 = runtimeEntityType.AddProperty(
                "Attribute7",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute7", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute7>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute7.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute7.AddAnnotation("Relational:ColumnName", "ATTRIBUTE7");

            var attribute8 = runtimeEntityType.AddProperty(
                "Attribute8",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute8", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute8>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute8.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute8.AddAnnotation("Relational:ColumnName", "ATTRIBUTE8");

            var attribute9 = runtimeEntityType.AddProperty(
                "Attribute9",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Attribute9", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Attribute9>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attribute9.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attribute9.AddAnnotation("Relational:ColumnName", "ATTRIBUTE9");

            var attributeCategory = runtimeEntityType.AddProperty(
                "AttributeCategory",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("AttributeCategory", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<AttributeCategory>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            attributeCategory.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            attributeCategory.AddAnnotation("Relational:ColumnName", "ATTRIBUTE_CATEGORY");

            var automaticallyCreatedFlag = runtimeEntityType.AddProperty(
                "AutomaticallyCreatedFlag",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("AutomaticallyCreatedFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<AutomaticallyCreatedFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            automaticallyCreatedFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            automaticallyCreatedFlag.AddAnnotation("Relational:ColumnName", "AUTOMATICALLY_CREATED_FLAG");

            var chartOfAccountsId = runtimeEntityType.AddProperty(
                "ChartOfAccountsId",
                typeof(decimal?),
                propertyInfo: typeof(GlAccessSet).GetProperty("ChartOfAccountsId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<ChartOfAccountsId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            chartOfAccountsId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            chartOfAccountsId.AddAnnotation("Relational:ColumnName", "CHART_OF_ACCOUNTS_ID");
            chartOfAccountsId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            createdBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            createdBy.AddAnnotation("Relational:ColumnName", "CREATED_BY");

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime?),
                propertyInfo: typeof(GlAccessSet).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            creationDate.AddAnnotation("Relational:ColumnName", "CREATION_DATE");
            creationDate.AddAnnotation("Relational:ColumnType", "DATE");

            var defaultLedgerId = runtimeEntityType.AddProperty(
                "DefaultLedgerId",
                typeof(decimal?),
                propertyInfo: typeof(GlAccessSet).GetProperty("DefaultLedgerId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<DefaultLedgerId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            defaultLedgerId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            defaultLedgerId.AddAnnotation("Relational:ColumnName", "DEFAULT_LEDGER_ID");
            defaultLedgerId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 150,
                unicode: false);
            description.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            description.AddAnnotation("Relational:ColumnName", "DESCRIPTION");

            var enabledFlag = runtimeEntityType.AddProperty(
                "EnabledFlag",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("EnabledFlag", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<EnabledFlag>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            enabledFlag.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            enabledFlag.AddAnnotation("Relational:ColumnName", "ENABLED_FLAG");

            var lastUpdateDate = runtimeEntityType.AddProperty(
                "LastUpdateDate",
                typeof(DateTime?),
                propertyInfo: typeof(GlAccessSet).GetProperty("LastUpdateDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<LastUpdateDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastUpdateDate.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateDate.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_DATE");
            lastUpdateDate.AddAnnotation("Relational:ColumnType", "DATE");

            var lastUpdateLogin = runtimeEntityType.AddProperty(
                "LastUpdateLogin",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("LastUpdateLogin", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<LastUpdateLogin>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdateLogin.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdateLogin.AddAnnotation("Relational:ColumnName", "LAST_UPDATE_LOGIN");

            var lastUpdatedBy = runtimeEntityType.AddProperty(
                "LastUpdatedBy",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("LastUpdatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<LastUpdatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            lastUpdatedBy.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            lastUpdatedBy.AddAnnotation("Relational:ColumnName", "LAST_UPDATED_BY");

            var name = runtimeEntityType.AddProperty(
                "Name",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("Name", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<Name>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            name.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            name.AddAnnotation("Relational:ColumnName", "NAME");

            var objectVersionNumber = runtimeEntityType.AddProperty(
                "ObjectVersionNumber",
                typeof(decimal?),
                propertyInfo: typeof(GlAccessSet).GetProperty("ObjectVersionNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<ObjectVersionNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            objectVersionNumber.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            objectVersionNumber.AddAnnotation("Relational:ColumnName", "OBJECT_VERSION_NUMBER");
            objectVersionNumber.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var periodSetName = runtimeEntityType.AddProperty(
                "PeriodSetName",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("PeriodSetName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<PeriodSetName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            periodSetName.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            periodSetName.AddAnnotation("Relational:ColumnName", "PERIOD_SET_NAME");

            var securedSegValueSetId = runtimeEntityType.AddProperty(
                "SecuredSegValueSetId",
                typeof(decimal?),
                propertyInfo: typeof(GlAccessSet).GetProperty("SecuredSegValueSetId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<SecuredSegValueSetId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            securedSegValueSetId.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            securedSegValueSetId.AddAnnotation("Relational:ColumnName", "SECURED_SEG_VALUE_SET_ID");
            securedSegValueSetId.AddAnnotation("Relational:ColumnType", "NUMBER(38)");

            var securitySegmentCode = runtimeEntityType.AddProperty(
                "SecuritySegmentCode",
                typeof(string),
                propertyInfo: typeof(GlAccessSet).GetProperty("SecuritySegmentCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GlAccessSet).GetField("<SecuritySegmentCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            securitySegmentCode.AddAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.None);
            securitySegmentCode.AddAnnotation("Relational:ColumnName", "SECURITY_SEGMENT_CODE");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "FUSION");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "GL_ACCESS_SETS");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}