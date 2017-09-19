Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore.Authorization
Imports Microsoft.AspNetCore.Mvc

Namespace FirstCSharpWebApp.Controllers
    <Route("api/[controller]")>
    Public Class ValuesController
        Inherits Controller

        ' GET api/values
        <HttpGet>
        Public Function [Get]() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET api/values/5
        <HttpGet("{id}")>
        Public Function [Get](ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST api/values
        <HttpPost>
        Public Sub Post(<FromBody> ByVal value As String)
            ' For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        End Sub

        ' PUT api/values/5
        <HttpPut("{id}")>
        Public Sub Put(ByVal id As Integer, <FromBody> ByVal value As String)
            ' For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        End Sub

        ' DELETE api/values/5
        <HttpDelete("{id}")>
        Public Sub Delete(ByVal id As Integer)
            ' For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        End Sub
    End Class
End Namespace