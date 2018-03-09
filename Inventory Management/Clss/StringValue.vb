﻿Public Class StringList
    Dim List As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
    Sub New()
        With List
            Try
#Region "วัสดุ"
                .Add("matid", "รหัสวัสดุ")
                .Add("matname", "วัสดุ")
                .Add("Ratio", "เรโช")
                .Add("ratio_name", " ")
                .Add("Qtyperunit", "หน่วยบรรจุ")
                .Add("Qtyperunit_name", " ")
                .Add("Qtyofusing", "ประมาณการใช้ต่อเดือน")
                .Add("Qtyofusing_name", " ")
                .Add("unit1_num", "จำนวน")
                .Add("unit1_name", " ")
                .Add("unit3_num", " รวมเป็น")
                .Add("unit3_name", " ")
                .Add("tagid", "เลขแทร็ค")
                .Add("notation", "หมายเหตุ")
                .Add("warn", "ระดับการแจ้งเตือน (เดือน)")
                .Add("warn_name", " ")
                .Add("unit1", List("unit1_num"))
                .Add("unit3", List("unit3_num"))
                .Add("warn1", "ใช้ได้อีก")
                .Add("dozen", "จำนวนโหล")
#End Region
#Region "ประวัติเบิก/นำเข้า"
                .Add("BillNo", "เลขที่บิล")
                .Add("ImportDate", "วันที่นำเข้า")
                .Add("RequestNo", "เลขที่เบิก")
                .Add("RequestDate", "วันที่เบิกวัสดุ")
                .Add("UserRequest", "ผู้เบิกวัสดุ")
                .Add("SaveDate", "วันที่บันทึกข้อมูล")
                .Add("userstock", "ผู้ทำรายการ")
                .Add("userstock_name", List("userstock"))
                .Add("unit1_sum", List("unit1"))
                .Add("unit3_sum", List("unit3"))
                .Add("username", List("userstock"))
#End Region
#Region "QC"
                .Add("productid", "รหัสรายการ")
                .Add("productname", "เบอร์มีด")
                .Add("qctarget", "เป้าผลิต")
                .Add("qcnote", " ")
                .Add("unit", " ")
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
                .Add("transferno", "เลขที่รายการ")
                .Add("transferdate", "วันที่รับของ")
                .Add("locsrc_name", "คลังต้นทาง")
                .Add("locdest_name", "คลังปลายทาง")
                .Add("apvstat1", "ปกติ")
                .Add("apvstat2", "ไม่ปกติ")
                .Add("apvstat0", "ไม่พบตามรายการ")
                .Add("approveStat", "สถานะรับของ")
                .Add("Locname", "คลังวัสดุ")
#End Region
#Region "ทั่วไป"
                .Add("err_pagesize", "จำนวนหน้า เกินจำนวนข้อมูลที่มีอยู่")
                .Add("err_norow", "ยังไม่มีข้อมูลส่วนนี้")
                .Add("ReqToday", " ")
#End Region

            Catch ex As Exception
                Dim st As New StackTrace(True)
                st = New StackTrace(ex, True)
                Dim Lines As String = st.GetFrame(st.FrameCount - 1).GetFileLineNumber

                MsgBox(ex.Message & vbNewLine & vbNewLine _
                    & "Error Line : " & Lines _
                    & vbNewLine & vbNewLine _
                    & "After This " _
                    & vbNewLine _
                    & "Keys : " & .Keys.Last.ToString & vbNewLine & "Value : " & .Last.Value.ToString)
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
