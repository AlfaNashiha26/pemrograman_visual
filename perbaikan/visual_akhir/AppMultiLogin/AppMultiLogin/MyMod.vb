﻿Module MyMod
    Public api_folder As String = "appakademik"
    Public users_api As String = "http://f0833850.xsph.ru/" & api_folder & "/users_api.php"
    Public sparepart_api As String = "http://f0833850.xsph.ru/" & api_folder & "/sparepart_api.php"
    Public sparepart_baru As Boolean
    Public penjualan_api As String = "http://f0833850.xsph.ru/" & api_folder & "/penjualan_api.php"
    Public penjualan_baru As Boolean
    Public Dashboard As New Form1
    Public Admin1Form As New Admin1
    Public Admin2Form As New Admin2
    Public LoginForm As New Login
    Public admin_role As Boolean = False
    Public dosen_role As Boolean = False
    Public mahasiswa_role As Boolean = False
    Public login_valid As Boolean = False

End Module
