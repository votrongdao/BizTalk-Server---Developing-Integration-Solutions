namespace Management {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Management.CustomerOrder",@"CustomerOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CustomerOrder"})]
    public sealed class CustomerOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Management.CustomerOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://OrderSchemas.PropertySchema"" targetNamespace=""http://Management.CustomerOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CustomerOrder"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Title"" type=""xs:string"" />
        <xs:element name=""FirstName"" type=""xs:string"" />
        <xs:element name=""LastName"" type=""xs:string"" />
        <xs:element name=""CustomerContact"" type=""xs:string"" />
        <xs:element name=""CustomerPONumber"" type=""xs:string"" />
        <xs:element name=""Priority"" type=""xs:string"" />
        <xs:element name=""QuoteReferenceID"" type=""xs:string"" />
        <xs:element name=""SalesOrderReferenceID"" type=""xs:string"" />
        <xs:element name=""CreatedDate"" type=""xs:string"" />
        <xs:element name=""FreightAmount"" type=""xs:string"" />
        <xs:element name=""MiscCharges"" type=""xs:string"" />
        <xs:element name=""SubTotal"" type=""xs:string"" />
        <xs:element name=""TotalOrderAmount"" type=""xs:double"" />
        <xs:element name=""Address"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Street"" type=""xs:string"" />
              <xs:element name=""City"" type=""xs:string"" />
              <xs:element name=""State"" type=""xs:string"" />
              <xs:element name=""Zip"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Lines"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""SalesOrderLine"">
                <xs:complexType>
                  <xs:sequence maxOccurs=""unbounded"">
                    <xs:element name=""LineNumber"" type=""xs:string"" />
                    <xs:element name=""UnitPrice"" type=""xs:string"" />
                    <xs:element name=""Quantity"" type=""xs:string"" />
                    <xs:element name=""ItemID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Status"" type=""xs:string"" />
        <xs:element name=""Comments"" type=""xs:string"" />
        <xs:element name=""UnitPrice"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CustomerOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CustomerOrder";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
