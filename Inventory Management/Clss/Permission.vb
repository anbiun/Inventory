Option Explicit On
Option Strict On

Namespace Permission
    Public Class Main
        Public Enum UserLevel As Integer
            User = 0
            Po = 2
            Stock = 3
            Manger = 4
            Admin = 5
        End Enum
        Sub New(Level As UserLevel)
            Select Case Level
                Case UserLevel.Po
                    Dim userLevel2 As New UserLevel2
                Case UserLevel.Stock
                    Dim userLevel3 As New UserLevel3
                Case UserLevel.Manger
                    Dim userLevel4 As New UserLevel4
                Case UserLevel.Admin
                    Return
                Case Else
                    Dim userLevel1 As New UserLevel1
            End Select
        End Sub
    End Class
    Public Class UserLevel1
        Sub New()
            With FrmMatImport
                .grpSearch.Visible = True
                .grpSearch.Visible = True
                .pnlEdit.Visible = False
            End With
            FrmLogs_Requisition.BtnDel.Visible = False
            With FrmMain
                .ribGrpApprove.Visible = True
                .btnStock.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .ribGrpSetting.Visible = False
                .ribGrpNewSub.Visible = False
                .RibbonPage2.Visible = False
            End With
        End Sub
    End Class
    Public Class UserLevel2
        Sub New()
            With FrmMatList
                .PnlTreeButton.Visible = False
            End With
            With FrmMain
                .ribGrpImport.Visible = False
                .btnTransfer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .btnLogs_Req.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .btnLogs_Transfer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .btnUnitManager.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .btnSubMat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .btnQCTarget.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End With
        End Sub
    End Class
    Public Class UserLevel3
        Inherits UserLevel1
        Sub New()
            FrmMain.btnStock.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            FrmMain.ribGrpSetting.Visible = True
        End Sub
    End Class
    Public Class UserLevel4
        Sub New()
            FrmMatImport.pnlEdit.Visible = False
        End Sub
    End Class
End Namespace
