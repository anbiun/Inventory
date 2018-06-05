Public Class StringList
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
                .Add("BillNo", "เลขที่ใบส่งของ")
                .Add("ImportDate", "วันที่นำเข้า")
                .Add("RequestNo", "เลขที่เบิก")
                .Add("RequestDate", "วันที่เบิกวัสดุ")
                .Add("UserRequest", "ผู้เบิกวัสดุ")
                .Add("SaveDate", "วันที่บันทึกข้อมูล")
                .Add("DateSave", "วันที่บันทึกข้อมูล")
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
                .Add("qcnote", "เป้าผลิต")
                .Add("unit", " ")
#End Region
#Region "Supplier"
                .Add("SupplierName", "ชื่อผู้ขาย")
                .Add("SupplierAddress", "ที่อยู่ผู้ขาย")
                .Add("SupplierAgent", "บุคลลที่ติดต่อ")
                .Add("SupplierContact", "ติดต่อ")
                .Add("SupplierTerm", "เงื่อนไขการชำระเงิน")


#End Region
#Region "หมวดวัสดุหลัก/รอง"
                .Add("catname", "หมวดวัสดุ")
                .Add("subcatname", "ประเภทวัสดุ")
#End Region
#Region "ตรวจรับของ/โอนย้าย"
                .Add("dateapprove", "วันที่ตรวจรับ")
                .Add("userapprove", "ผู้ตรวจรับ")
                .Add("approvenote", "หมายเหตุรับของ")
                .Add("transferno", "เลขที่รายการ")
                .Add("DateTransfer", "วันที่โอนย้าย")
                .Add("locsrc_name", "คลังต้นทาง")
                .Add("locdest_name", "คลังปลายทาง")
                .Add("apvstat1", "รับของ")
                .Add("apvstat2", "ตีกลับ")
                .Add("apvstat0", "จัดส่ง")
                .Add("apvstat3", "ไม่ตรง")
                .Add("approveStat", "สถานะรับของ")
                .Add("Locname", "คลังวัสดุ")
                .Add("LocShort", "ชื่อย่อ")
                .Add("LocSrc", "ต้นทาง")
                .Add("LocDest", "ปลายทาง")
                .Add("LocID_SrcName", List("LocSrc"))
                .Add("LocID_DestName", List("LocDest"))
#End Region
#Region "ทั่วไป"
                .Add("err_pagesize", "จำนวนหน้า เกินจำนวนข้อมูลที่มีอยู่")
                .Add("err_norow", "ยังไม่มีข้อมูลส่วนนี้")
                .Add("PoStat", " ")
                .Add("Stat", "สถานะ")
                .Add("matStat0", "เลิกใช้งาน")
                .Add("matStat1", "ใช้งาน")
#End Region
#Region "PO"
                .Add("PoNo", "เลขที่ใบ Po")
                .Add("PoDate", "วันที่เปิด Po")
                .Add("Owing", "ค้างส่ง")
                .Add("DeliveryDate", "กำหนดส่ง")
                .Add("RatioPO", "ขนาดบรรจุภัณฑ์")
                .Add("UnitImport", "ส่งแล้ว")
                .Add("postat0", "อยู่ระหว่างจัดซื้อ")
                .Add("postat1", "จัดส่งครบแล้ว")
                .Add("postat2", "ค้างส่ง")
                .Add("Del", "ลบ")
                .Add("MatNotation", "รายละเอียดเพิ่มเติม")
                .Add("PriceSum", "จำนวนเงิน")
                .Add("UnitPrice", "ราคา / หน่วย")
#End Region
#Region "Stock"
                For i As Integer = 1 To 12
                    .Add(MonthName(i), MonthName(i))
                Next
                .Add("JL", "JL")
                .Add("kiwi", "KIWI")
                .Add("JLK", "JLK")
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
        If String.IsNullOrEmpty(Result) Then Return " "
        Return Result
    End Function
End Class
