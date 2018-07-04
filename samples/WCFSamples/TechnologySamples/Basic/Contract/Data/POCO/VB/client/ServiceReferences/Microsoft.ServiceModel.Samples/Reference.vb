﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1433
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace Microsoft.ServiceModel.Samples
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="ComplexNumber", [Namespace]:="http://schemas.datacontract.org/2004/07/Microsoft.ServiceModel.Samples"),  _
     System.SerializableAttribute()>  _
    Partial Public Class ComplexNumber
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ImaginaryField As Double
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private RealField As Double
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Imaginary() As Double
            Get
                Return Me.ImaginaryField
            End Get
            Set
                If (Me.ImaginaryField.Equals(value) <> true) Then
                    Me.ImaginaryField = value
                    Me.RaisePropertyChanged("Imaginary")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Real() As Double
            Get
                Return Me.RealField
            End Get
            Set
                If (Me.RealField.Equals(value) <> true) Then
                    Me.RealField = value
                    Me.RaisePropertyChanged("Real")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://Microsoft.ServiceModel.Samples", ConfigurationName:="Microsoft.ServiceModel.Samples.IDataContractCalculator")>  _
    Public Interface IDataContractCalculator
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/IDataContractCalculator/Add", ReplyAction:="http://Microsoft.ServiceModel.Samples/IDataContractCalculator/AddResponse")>  _
        Function Add(ByVal n1 As Microsoft.ServiceModel.Samples.ComplexNumber, ByVal n2 As Microsoft.ServiceModel.Samples.ComplexNumber) As Microsoft.ServiceModel.Samples.ComplexNumber
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/IDataContractCalculator/Subtract", ReplyAction:="http://Microsoft.ServiceModel.Samples/IDataContractCalculator/SubtractResponse")>  _
        Function Subtract(ByVal n1 As Microsoft.ServiceModel.Samples.ComplexNumber, ByVal n2 As Microsoft.ServiceModel.Samples.ComplexNumber) As Microsoft.ServiceModel.Samples.ComplexNumber
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/IDataContractCalculator/Multiply", ReplyAction:="http://Microsoft.ServiceModel.Samples/IDataContractCalculator/MultiplyResponse")>  _
        Function Multiply(ByVal n1 As Microsoft.ServiceModel.Samples.ComplexNumber, ByVal n2 As Microsoft.ServiceModel.Samples.ComplexNumber) As Microsoft.ServiceModel.Samples.ComplexNumber
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/IDataContractCalculator/Divide", ReplyAction:="http://Microsoft.ServiceModel.Samples/IDataContractCalculator/DivideResponse")>  _
        Function Divide(ByVal n1 As Microsoft.ServiceModel.Samples.ComplexNumber, ByVal n2 As Microsoft.ServiceModel.Samples.ComplexNumber) As Microsoft.ServiceModel.Samples.ComplexNumber
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface IDataContractCalculatorChannel
        Inherits Microsoft.ServiceModel.Samples.IDataContractCalculator, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class DataContractCalculatorClient
        Inherits System.ServiceModel.ClientBase(Of Microsoft.ServiceModel.Samples.IDataContractCalculator)
        Implements Microsoft.ServiceModel.Samples.IDataContractCalculator
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Add(ByVal n1 As Microsoft.ServiceModel.Samples.ComplexNumber, ByVal n2 As Microsoft.ServiceModel.Samples.ComplexNumber) As Microsoft.ServiceModel.Samples.ComplexNumber Implements Microsoft.ServiceModel.Samples.IDataContractCalculator.Add
            Return MyBase.Channel.Add(n1, n2)
        End Function
        
        Public Function Subtract(ByVal n1 As Microsoft.ServiceModel.Samples.ComplexNumber, ByVal n2 As Microsoft.ServiceModel.Samples.ComplexNumber) As Microsoft.ServiceModel.Samples.ComplexNumber Implements Microsoft.ServiceModel.Samples.IDataContractCalculator.Subtract
            Return MyBase.Channel.Subtract(n1, n2)
        End Function
        
        Public Function Multiply(ByVal n1 As Microsoft.ServiceModel.Samples.ComplexNumber, ByVal n2 As Microsoft.ServiceModel.Samples.ComplexNumber) As Microsoft.ServiceModel.Samples.ComplexNumber Implements Microsoft.ServiceModel.Samples.IDataContractCalculator.Multiply
            Return MyBase.Channel.Multiply(n1, n2)
        End Function
        
        Public Function Divide(ByVal n1 As Microsoft.ServiceModel.Samples.ComplexNumber, ByVal n2 As Microsoft.ServiceModel.Samples.ComplexNumber) As Microsoft.ServiceModel.Samples.ComplexNumber Implements Microsoft.ServiceModel.Samples.IDataContractCalculator.Divide
            Return MyBase.Channel.Divide(n1, n2)
        End Function
    End Class
End Namespace