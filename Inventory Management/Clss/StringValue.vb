Public Class StringList
    Private List = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
    Sub New()
        With List
            Try
#Region "วัสดุ"
                .Add("matid", "รหัสวัสดุ")
                .Add("matname", "วัสดุ")
                .Add("Ratio", "เรโช")
                .Add("ratio_name", " ")
                .add("Qtyperunit", "หน่วยบรรจุ")
                .add("Qtyperunit_name", " ")
                .add("Qtyofusing", "ประมาณการใช้ต่อเดือน")
                .add("Qtyofusing_name", " ")
                .add("unit1_num", "จำนวน")
                .Add("unit1_name", " ")
                .Add("unit3_num", " รวมเป็น")
                .Add("unit3_name", " ")
                .add("tagid", "เลขแทค")
                .add("notation", "หมายเหตุ")
                .add("warn", "ระดับการแจ้งเตือน (เดือน)")
                .add("warn_name", " ")
                .add("unit1", List("unit1_num"))
                .add("unit3", List("unit3_num"))
                .add("warn1", "ใช้ได้อีก")
                .add("dozen", "จำนวนโหล")
                .add("qcnote", " ")
#End Region
#Region "QC"
                .add("productid", "รหัสรายการ")
                .add("productname", "เบอร์มีด")
                .add("qctarget", "เป้าผลิต")
                .add("unit", " ")
#End Region
#Region "Supplier"
                .Add("suppliername", "ชื่อผู้ขาย")
#End Region
#Region "หมวดวัสดุหลัก/รอง"
                .Add("catname", "หมวดวัสดุ")
                .Add("subcatname", "ประเภทวัสดุ")
#End Region
#Region "ตรวจรับของ/โอนย้าย"
                .Add("approvedate", "วันที่ตรวจรับ")
                .Add("userapprove", "ผู้ตรวจรับ")
                .Add("approvenote", "หมายเหตุรับของ")
                .add("transferno", "เลขที่รายการ")
                .add("transferdate", "วันที่รับของ")
                .add("locsrc_name", "คลังต้นทาง")
                .add("locdest_name", "คลังปลายทาง")
                .add("apvstat1", "ปกติ")
                .add("apvstat2", "ไม่ปกติ")
                .add("apvstat0", "ไม่พบตามรายการ")
                .add("approveStat", "สถานะรับของ")
#End Region

            Catch ex As Exception
                MsgBox(ex.Message & vbNewLine & "Error Class : " & Me.GetType.Name)
                End
            End Try
        End With
    End Sub

    Function GetVal(StringKey As String) As String
        Dim Result As String = String.Empty
        If List.ContainsKey(StringKey) Then
            Result = List(StringKey)
        End If
        Return Result
    End Function
End Class
