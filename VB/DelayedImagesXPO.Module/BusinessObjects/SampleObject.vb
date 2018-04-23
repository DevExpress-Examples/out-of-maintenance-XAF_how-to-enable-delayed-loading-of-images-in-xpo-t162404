Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Model
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace DelayedImagesXPO.Module.BusinessObjects
    <DefaultClassOptions> _
    Public Class SampleObject
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private name_Renamed As String
        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", name_Renamed, value)
            End Set
        End Property
        <Delayed, ImageEditor, VisibleInListView(True)> _
        Public Property Image() As Byte()
            Get
                Return GetDelayedPropertyValue(Of Byte())("Image")
            End Get
            Set(ByVal value As Byte())
                SetDelayedPropertyValue(Of Byte())("Image", value)
            End Set
        End Property
    End Class
End Namespace
