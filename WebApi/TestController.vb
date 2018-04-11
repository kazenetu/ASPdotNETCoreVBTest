Imports System
Imports System.Collections.Generic
Imports Microsoft.AspNetCore.Http
Imports Microsoft.AspNetCore.Mvc

Namespace WebApi.Controllers
    <Route("api/test")>
    public class TestController 
                    Inherits Controller

    Public Sub New()
        System.Diagnostics.Debug .WriteLine("VB!")
    End Sub

        'GET: api/Test
        <HttpGet("get")>
        public function  GetFunc() as IActionResult
            Return Json(New String() {"value1", "value2"})
            'return New String() {"value1", "value2"}
        end function


        <HttpGet("test")>
        public function  Test() as IEnumerable(Of String)
            'Return Json(New String() {"value1", "value2"})
            return New String() {"value3", "value4"}
        end function
    end class
end Namespace