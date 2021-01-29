///////////////////////////////////////////////////////////////////////////
//           Liquid XML Objects GENERATED CODE - DO NOT MODIFY           //
//            https://www.liquid-technologies.com/xml-objects            //
//=======================================================================//
// Dependencies                                                          //
//     Nuget : LiquidTechnologies.XmlObjects.Runtime                     //
//           : MUST BE VERSION 17.0.6                                    //
//=======================================================================//
// Online Help                                                           //
//     https://www.liquid-technologies.com/xml-objects-quick-start-guide //
//=======================================================================//
// Licensing Information                                                 //
//     https://www.liquid-technologies.com/eula                          //
///////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Numerics;
using LiquidTechnologies.XmlObjects;
using LiquidTechnologies.XmlObjects.Attribution;

// ------------------------------------------------------
// |                      Settings                      |
// ------------------------------------------------------
// GenerateCommonBaseClass                  = False
// GenerateUnprocessedNodeHandlers          = False
// Language                                 = CS
// OutputNamespace                          = LiquidTechnologies.GeneratedLx
// WriteDefaultValuesForOptionalAttributes  = False
// WriteDefaultValuesForOptionalElements    = False
// GenerationModel                          = Simple
//                                            *WARNING* this simplified model that is very easy to work with
//                                            but may cause the XML to be produced without regard for element
//                                            cardinality or order. Where very high compliance with the XML Schema
//                                            standard is required use GenerationModelType.Conformant
// XSD Schema Files
//    file://sandbox/schema.xsd


namespace LiquidTechnologies.GeneratedLx
{
    #region Global Settings
    /// <summary>Contains library level properties, and ensures the version of the runtime used matches the version used to generate it.</summary>
    [LxRuntimeRequirements("17.0.6.9344", "Trial for Non-Commercial Use Expiry [2020-03-19]", "24CAVFDGV38C1K4W", LiquidTechnologies.XmlObjects.LicenseTermsType.Trial)]
    public partial class LxRuntimeRequirementsWritten
    {
    }

    #endregion

}

namespace LiquidTechnologies.GeneratedLx.Xs
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType anyType@http://www.w3.org/2001/XMLSchema</summary>
    /// <XsdPath>schema:.../www.w3.org/2001/XMLSchema/complexType:anyType</XsdPath>
    /// <XsdFile>http://www.w3.org/2001/XMLSchema</XsdFile>
    /// <XsdLocation>Empty</XsdLocation>
    [LxSimpleComplexTypeDefinition("anyType", "http://www.w3.org/2001/XMLSchema")]
    public partial class AnyTypeCt : XElement
    {
        /// <summary>Constructor : create a <see cref="AnyTypeCt" /> element &lt;anyType xmlns='http://www.w3.org/2001/XMLSchema'&gt;</summary>
        public AnyTypeCt() : base(XName.Get("anyType", "http://www.w3.org/2001/XMLSchema")) { }

    }

    #endregion

}

namespace LiquidTechnologies.GeneratedLx.Ns
{
    #region Elements
    /// <summary>A class representing the root XSD element AggregatedMeteringDataReport</summary>
    /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport</XsdPath>
    /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
    /// <XsdLocation>4:3-94:16</XsdLocation>
    [LxSimpleElementDefinition("AggregatedMeteringDataReport", "", ElementScopeType.GlobalElement)]
    public partial class AggregatedMeteringDataReportElm
    {
        /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.DocumentIdentificationElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.DocumentIdentificationElm DocumentIdentification { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.DocumentIdentificationElm();

        /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.SenderIdentificationElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.SenderIdentificationElm SenderIdentification { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.SenderIdentificationElm();

        /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.ReceiverIdentificationElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.ReceiverIdentificationElm ReceiverIdentification { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.ReceiverIdentificationElm();

        /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.DocumentDateTimeElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.DocumentDateTimeElm DocumentDateTime { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.DocumentDateTimeElm();

        /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.PortfolioCustomerIdentificationElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.PortfolioCustomerIdentificationElm PortfolioCustomerIdentification { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.PortfolioCustomerIdentificationElm();

        /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm" />, Required : should not be set to null</summary>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm TimeSeries { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm();

        /// <summary>Represent the inline xs:element DocumentIdentification.</summary>
        /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:DocumentIdentification</XsdPath>
        /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
        /// <XsdLocation>7:9-11:22</XsdLocation>
        [LxSimpleElementDefinition("DocumentIdentification", "", ElementScopeType.InlineElement)]
        public partial class DocumentIdentificationElm
        {
            /// <summary>The value for the attribute v</summary>
            /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:DocumentIdentification/attribute:v</XsdPath>
            /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
            /// <XsdLocation>9:13-9:76</XsdLocation>
            [LxAttribute("v", "", LxValueType.Value, XsdType.XsdUnsignedLong, Required = true)]
            public System.UInt64 V { get; set; }

        }

        /// <summary>Represent the inline xs:element SenderIdentification.</summary>
        /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:SenderIdentification</XsdPath>
        /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
        /// <XsdLocation>12:9-16:22</XsdLocation>
        [LxSimpleElementDefinition("SenderIdentification", "", ElementScopeType.InlineElement)]
        public partial class SenderIdentificationElm
        {
            /// <summary>The value for the attribute v</summary>
            /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:SenderIdentification/attribute:v</XsdPath>
            /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
            /// <XsdLocation>14:13-14:70</XsdLocation>
            [LxAttribute("v", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String V { get; set; } = "";

        }

        /// <summary>Represent the inline xs:element ReceiverIdentification.</summary>
        /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:ReceiverIdentification</XsdPath>
        /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
        /// <XsdLocation>17:9-21:22</XsdLocation>
        [LxSimpleElementDefinition("ReceiverIdentification", "", ElementScopeType.InlineElement)]
        public partial class ReceiverIdentificationElm
        {
            /// <summary>The value for the attribute v</summary>
            /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:ReceiverIdentification/attribute:v</XsdPath>
            /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
            /// <XsdLocation>19:13-19:70</XsdLocation>
            [LxAttribute("v", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String V { get; set; } = "";

        }

        /// <summary>Represent the inline xs:element DocumentDateTime.</summary>
        /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:DocumentDateTime</XsdPath>
        /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
        /// <XsdLocation>22:9-26:22</XsdLocation>
        [LxSimpleElementDefinition("DocumentDateTime", "", ElementScopeType.InlineElement)]
        public partial class DocumentDateTimeElm
        {
            /// <summary>The value for the attribute v</summary>
            /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:DocumentDateTime/attribute:v</XsdPath>
            /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
            /// <XsdLocation>24:13-24:72</XsdLocation>
            [LxAttribute("v", "", LxValueType.Value, XsdType.XsdDateTime, Required = true)]
            public LiquidTechnologies.XmlObjects.LxDateTime V { get; set; }

        }

        /// <summary>Represent the inline xs:element PortfolioCustomerIdentification.</summary>
        /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:PortfolioCustomerIdentification</XsdPath>
        /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
        /// <XsdLocation>27:9-31:22</XsdLocation>
        [LxSimpleElementDefinition("PortfolioCustomerIdentification", "", ElementScopeType.InlineElement)]
        public partial class PortfolioCustomerIdentificationElm
        {
            /// <summary>The value for the attribute v</summary>
            /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:PortfolioCustomerIdentification/attribute:v</XsdPath>
            /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
            /// <XsdLocation>29:13-29:70</XsdLocation>
            [LxAttribute("v", "", LxValueType.Value, XsdType.XsdString, Required = true)]
            public System.String V { get; set; } = "";

        }

        /// <summary>Represent the inline xs:element TimeSeries.</summary>
        /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries</XsdPath>
        /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
        /// <XsdLocation>32:9-91:22</XsdLocation>
        [LxSimpleElementDefinition("TimeSeries", "", ElementScopeType.InlineElement)]
        public partial class TimeSeriesElm
        {
            /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.MeasurementUnitElm" />, Required : should not be set to null</summary>
            [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
            public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.MeasurementUnitElm MeasurementUnit { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.MeasurementUnitElm();

            /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm" />, Required : should not be set to null</summary>
            [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
            public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm Period { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm();

            /// <summary>Represent the inline xs:element MeasurementUnit.</summary>
            /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:MeasurementUnit</XsdPath>
            /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
            /// <XsdLocation>35:15-39:28</XsdLocation>
            [LxSimpleElementDefinition("MeasurementUnit", "", ElementScopeType.InlineElement)]
            public partial class MeasurementUnitElm
            {
                /// <summary>The value for the attribute v</summary>
                /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:MeasurementUnit/attribute:v</XsdPath>
                /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                /// <XsdLocation>37:19-37:76</XsdLocation>
                [LxAttribute("v", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                public System.String V { get; set; } = "";

            }

            /// <summary>Represent the inline xs:element Period.</summary>
            /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period</XsdPath>
            /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
            /// <XsdLocation>40:15-88:28</XsdLocation>
            [LxSimpleElementDefinition("Period", "", ElementScopeType.InlineElement)]
            public partial class PeriodElm
            {
                /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.TimeIntervalElm" />, Required : should not be set to null</summary>
                [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.TimeIntervalElm TimeInterval { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.TimeIntervalElm();

                /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.ResolutionElm" />, Required : should not be set to null</summary>
                [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.ResolutionElm Resolution { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.ResolutionElm();

                /// <summary>A collection of <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm" /></summary>
                [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                public List<LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm> AccountInterval { get; } = new List<LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm>();

                /// <summary>Represent the inline xs:element TimeInterval.</summary>
                /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:TimeInterval</XsdPath>
                /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                /// <XsdLocation>43:21-47:34</XsdLocation>
                [LxSimpleElementDefinition("TimeInterval", "", ElementScopeType.InlineElement)]
                public partial class TimeIntervalElm
                {
                    /// <summary>The value for the attribute v</summary>
                    /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:TimeInterval/attribute:v</XsdPath>
                    /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                    /// <XsdLocation>45:25-45:82</XsdLocation>
                    [LxAttribute("v", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                    public System.String V { get; set; } = "";

                }

                /// <summary>Represent the inline xs:element Resolution.</summary>
                /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:Resolution</XsdPath>
                /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                /// <XsdLocation>48:21-52:34</XsdLocation>
                [LxSimpleElementDefinition("Resolution", "", ElementScopeType.InlineElement)]
                public partial class ResolutionElm
                {
                    /// <summary>The value for the attribute v</summary>
                    /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:Resolution/attribute:v</XsdPath>
                    /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                    /// <XsdLocation>50:25-50:84</XsdLocation>
                    [LxAttribute("v", "", LxValueType.Value, XsdType.XsdDuration, Required = true)]
                    public LiquidTechnologies.XmlObjects.LxDuration V { get; set; }

                }

                /// <summary>Represent the inline xs:element AccountInterval.</summary>
                /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:AccountInterval</XsdPath>
                /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                /// <XsdLocation>53:21-85:34</XsdLocation>
                [LxSimpleElementDefinition("AccountInterval", "", ElementScopeType.InlineElement)]
                public partial class AccountIntervalElm
                {
                    /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.PosElm" />, Required : should not be set to null</summary>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.PosElm Pos { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.PosElm();

                    /// <summary>A collection of <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MeasurementUnitElm" /></summary>
                    [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                    public List<LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MeasurementUnitElm> MeasurementUnit { get; } = new List<LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MeasurementUnitElm>();

                    /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MissingElm" />, Required : should not be set to null</summary>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MissingElm Missing { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MissingElm();

                    /// <summary>Represent the inline xs:element Pos.</summary>
                    /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:AccountInterval/sequence/element:Pos</XsdPath>
                    /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                    /// <XsdLocation>56:27-60:40</XsdLocation>
                    [LxSimpleElementDefinition("Pos", "", ElementScopeType.InlineElement)]
                    public partial class PosElm
                    {
                        /// <summary>The value for the attribute v</summary>
                        /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:AccountInterval/sequence/element:Pos/attribute:v</XsdPath>
                        /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                        /// <XsdLocation>58:31-58:94</XsdLocation>
                        [LxAttribute("v", "", LxValueType.Value, XsdType.XsdUnsignedByte, Required = true)]
                        public System.Byte V { get; set; }

                    }

                    /// <summary>Represent the inline xs:element MeasurementUnit.</summary>
                    /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:AccountInterval/sequence/element:MeasurementUnit</XsdPath>
                    /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                    /// <XsdLocation>61:27-77:40</XsdLocation>
                    [LxSimpleElementDefinition("MeasurementUnit", "", ElementScopeType.InlineElement)]
                    public partial class MeasurementUnitElm
                    {
                        /// <summary>The value for the attribute v</summary>
                        /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:AccountInterval/sequence/element:MeasurementUnit/attribute:v</XsdPath>
                        /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                        /// <XsdLocation>75:31-75:88</XsdLocation>
                        [LxAttribute("v", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                        public System.String V { get; set; } = "";

                        /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MeasurementUnitElm.OutQtyElm" />, Required : should not be set to null</summary>
                        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                        public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MeasurementUnitElm.OutQtyElm OutQty { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MeasurementUnitElm.OutQtyElm();

                        /// <summary>A <see cref="LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MeasurementUnitElm.InQtyElm" />, Required : should not be set to null</summary>
                        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                        public LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MeasurementUnitElm.InQtyElm InQty { get; set; } = new LiquidTechnologies.GeneratedLx.Ns.AggregatedMeteringDataReportElm.TimeSeriesElm.PeriodElm.AccountIntervalElm.MeasurementUnitElm.InQtyElm();

                        /// <summary>Represent the inline xs:element OutQty.</summary>
                        /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:AccountInterval/sequence/element:MeasurementUnit/sequence/element:OutQty</XsdPath>
                        /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                        /// <XsdLocation>64:33-68:46</XsdLocation>
                        [LxSimpleElementDefinition("OutQty", "", ElementScopeType.InlineElement)]
                        public partial class OutQtyElm
                        {
                            /// <summary>The value for the attribute v</summary>
                            /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:AccountInterval/sequence/element:MeasurementUnit/sequence/element:OutQty/attribute:v</XsdPath>
                            /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                            /// <XsdLocation>66:37-66:101</XsdLocation>
                            [LxAttribute("v", "", LxValueType.Value, XsdType.XsdUnsignedShort, Required = true)]
                            public System.UInt16 V { get; set; }

                        }

                        /// <summary>Represent the inline xs:element InQty.</summary>
                        /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:AccountInterval/sequence/element:MeasurementUnit/sequence/element:InQty</XsdPath>
                        /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                        /// <XsdLocation>69:33-73:46</XsdLocation>
                        [LxSimpleElementDefinition("InQty", "", ElementScopeType.InlineElement)]
                        public partial class InQtyElm
                        {
                            /// <summary>The value for the attribute v</summary>
                            /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:AccountInterval/sequence/element:MeasurementUnit/sequence/element:InQty/attribute:v</XsdPath>
                            /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                            /// <XsdLocation>71:37-71:95</XsdLocation>
                            [LxAttribute("v", "", LxValueType.Value, XsdType.XsdDecimal, Required = true)]
                            public LiquidTechnologies.XmlObjects.BigDecimal V { get; set; }

                        }

                    }

                    /// <summary>Represent the inline xs:element Missing.</summary>
                    /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:AccountInterval/sequence/element:Missing</XsdPath>
                    /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                    /// <XsdLocation>78:27-82:40</XsdLocation>
                    [LxSimpleElementDefinition("Missing", "", ElementScopeType.InlineElement)]
                    public partial class MissingElm
                    {
                        /// <summary>The value for the attribute v</summary>
                        /// <XsdPath>schema:schema.xsd/element:AggregatedMeteringDataReport/sequence/element:TimeSeries/sequence/element:Period/sequence/element:AccountInterval/sequence/element:Missing/attribute:v</XsdPath>
                        /// <XsdFile>file://sandbox/schema.xsd</XsdFile>
                        /// <XsdLocation>80:31-80:94</XsdLocation>
                        [LxAttribute("v", "", LxValueType.Value, XsdType.XsdUnsignedByte, Required = true)]
                        public System.Byte V { get; set; }

                    }

                }

            }

        }

    }

    #endregion

}
