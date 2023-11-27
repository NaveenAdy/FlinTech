Imports System.Configuration
Imports System.Data.SqlClient


Module GlobalVariables
    Public con As String = ConfigurationManager.ConnectionStrings("FlinTechConnection").ConnectionString
    Public userId As String
    Public userName As String
    Public loggedUser As String
    Public selectedTaskId As String
    Public selectedTaskName As String


End Module
